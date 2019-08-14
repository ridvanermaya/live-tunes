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

namespace LiveTunes.MVC.Controllers
{
    public class EventController : Controller
    {
        private readonly HttpClient client;
        private readonly ApplicationDbContext _context;
        /*public IEnumerable<Event> events;*/
        public EventController(ApplicationDbContext context)
        {
            client = new HttpClient();
            _context = context;

            if (_context.Events.Count() == 0)
            {
                _context.Events.Add(new Event { Latitude = 49.2746619, Longitude = -123.10921740000003, EventName = "King Gizzard and the Lizard Wizard" , DateTime = DateTime.Now, Genre = "Sci-Fi"});
                _context.Events.Add(new Event { Latitude = 49.2746619, Longitude = -123.0451041, EventName = "King Gizzard and the Lizard Wizard" , DateTime = DateTime.Now, Genre = "Sci-Fi"});
            }
        }

        public async Task GetEvents()
        {
            try
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue");
                //requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await client.SendAsync(requestMessage);

                // var events = _context.Events.Include(x => x.Likes).Where(x => x.EventId == 5).ToList();
                // var likes = _context.Likes.Where(x => x.EventId == 5).OrderByDescending(x => x.LikeId).Take(20);

                Debug.WriteLine(response.Content.ReadAsStringAsync());

            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public async Task<IActionResult> Index()
        {
            await GetEvents();
            return View();
        }
    }
}