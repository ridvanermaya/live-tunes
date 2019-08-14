using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
=======

>>>>>>> bca89d4199afc33d01ad1889da8d6aec3edf9403
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiveTunes.MVC.Models;
using System.Net.Http.Headers;
using System.Diagnostics;
<<<<<<< HEAD
using Microsoft.AspNetCore.Http;
=======
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using LiveTunes.MVC.Data;
>>>>>>> bca89d4199afc33d01ad1889da8d6aec3edf9403

namespace LiveTunes.MVC.Controllers
{
    public class EventController : Controller
    {
        private static HttpClient client;
<<<<<<< HEAD
=======
        private ApplicationDbContext _context;
>>>>>>> bca89d4199afc33d01ad1889da8d6aec3edf9403
        /*public IEnumerable<Event> events;*/
        EventController(ApplicationDbContext context)
        {
<<<<<<< HEAD
            client = new HttpClient();
        }
=======
            _context = context;
            client = new HttpClient();
>>>>>>> bca89d4199afc33d01ad1889da8d6aec3edf9403

        }
        static async Task GetEvents()
        {
            try


            {
<<<<<<< HEAD
                string token = "xxxxxxxxxxxxxxxx";

                /*var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue/");*/
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var result = await client.GetStringAsync("https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue/");
=======
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue");
                //requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
>>>>>>> bca89d4199afc33d01ad1889da8d6aec3edf9403

                Debug.WriteLine(result);
                //://www.eventbriteapi.com/v3/events/search


            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        
        public async Task<IActionResult> Details(int id)
        {
            Event e;
            e = _context.Events.Where(x => x.EventId == id).FirstOrDefault();
            
            return View(e);
        }

        public async Task<IActionResult> Index()
        {
            await GetEvents();
            return View();
        }
    }
}