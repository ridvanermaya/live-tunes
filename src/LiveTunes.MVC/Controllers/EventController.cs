using System;
using System.Collections.Generic;
using System.Linq;

using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiveTunes.MVC.Models;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using LiveTunes.MVC.Data;

namespace LiveTunes.MVC.Controllers
{
    public class EventController : Controller
    {
        private static HttpClient client;
        private ApplicationDbContext _context;
        /*public IEnumerable<Event> events;*/
        EventController(ApplicationDbContext context)
        {
            _context = context;
            client = new HttpClient();

        }
        static async Task GetEvents()
        {
            try
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue");
                //requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await client.SendAsync(requestMessage);

                Debug.WriteLine(response.Content.ReadAsStringAsync());

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