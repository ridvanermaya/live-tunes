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
        private static HttpClient client;

        /*public IEnumerable<Event> events;*/
        public EventController(ApplicationDbContext context)
        {
            client = new HttpClient();

            if (context.Events.Count() == 0)
            {
                context.Events.Add(new Event { Latitude = 49.2746619, Longitude = -123.10921740000003, EventName = "King Gizzard and the Lizard Wizard" , DateTime = DateTime.Now, Genre = "Sci-Fi"});
                context.Events.Add(new Event { Latitude = 49.2746619, Longitude = -123.0451041, EventName = "King Gizzard and the Lizard Wizard" , DateTime = DateTime.Now, Genre = "Sci-Fi"});
            }
        }

        static async Task GetEvents()

        {
            try
            {
                string token = "xxxxxxxxxxxxxxxx";

                /*var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue/");*/
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var result = await client.GetStringAsync("https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue/");

                var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue");
                //requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                Debug.WriteLine(result);
                //://www.eventbriteapi.com/v3/events/search

                // var events = _context.Events.Include(x => x.Likes).Where(x => x.EventId == 5).ToList();
                // var likes = _context.Likes.Where(x => x.EventId == 5).OrderByDescending(x => x.LikeId).Take(20);

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