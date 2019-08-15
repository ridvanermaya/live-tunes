using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiveTunes.MVC.Models;
using System.Net.Http.Headers;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using LiveTunes.MVC.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Security.Claims;

namespace LiveTunes.MVC.Controllers
{
    public class EventController : Controller
    {
        private static HttpClient client;
        private readonly ApplicationDbContext _context;

        /*public IEnumerable<Event> events;*/
        public EventController(ApplicationDbContext context)
        {
            client = new HttpClient();
            _context = context;

            if (context.Events.Count() <= 1)
            {
                context.Events.Add(new Event { Latitude = 49.2746619, Longitude = -123.10921740000003, EventName = "King Gizzard and the Lizard Wizard" , DateTime = DateTime.Now, Genre = "Post Punk"});
                context.Events.Add(new Event { Latitude = 49.2746619, Longitude = -123.0451041, EventName = "King Gizzard and the Lizard Wizard" , DateTime = DateTime.Now, Genre = "Post Punk"});
            }
            context.SaveChangesAsync();
        }

        static async Task GetEvents()

        {
            try
            {
                var result = await client.GetStringAsync("https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue&token=" + EventbriteAPIToken.Token);

                var deserializedResults = JsonConvert.DeserializeObject(result);    

            }
            catch (HttpRequestException e)
            {
                
            }
        }


        public async Task<IActionResult> Index()
        {
            await GetEvents();
            var events = await _context.Events.FirstOrDefaultAsync();

            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            var evnt = await _context.Events.FirstOrDefaultAsync(x => x.EventId == id);
            if (evnt == null) return NotFound();

            var userProfileId = 2;

            evnt.LikeCount = await _context.Likes.CountAsync(x => x.EventId == id);
            evnt.UserLiked = await _context.Likes.AnyAsync(x => x.EventId == id && x.UserId == userProfileId);

            return View(evnt);
        }

        [HttpPost]
        public async Task<IActionResult> Like(int id)
        {
            var evnt = await _context.Events.FirstOrDefaultAsync(x => x.EventId == id);
            if (evnt == null) return NotFound();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userProfile = await _context.UserProfiles.FirstOrDefaultAsync(x => x.UserId == userId);
            // var userProfileId = userProfile.UserProfileId;
            var userProfileId = 2;

            var like = await _context.Likes.FirstOrDefaultAsync(x => x.UserId == userProfileId && x.EventId == id);
            if (like != null)
            {
                _context.Remove(like);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { id });
            }

            like = new Like
            {
                EventId = id,
                UserId = userProfileId
            };

            _context.Likes.Add(like);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { id });
        }
    }
}