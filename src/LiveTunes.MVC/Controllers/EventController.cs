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

namespace LiveTunes.MVC.Controllers
{
    public class EventController : Controller
    {
        private static HttpClient client;
        /*public IEnumerable<Event> events;*/
        static EventController()
        {
            client = new HttpClient();
        }

        static async Task GetEvents()
        {
            try


            {
                string token = "xxxxxxxxxxxxxxxx";

                /*var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue/");*/
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var result = await client.GetStringAsync("https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue/");

                Debug.WriteLine(result);
                //://www.eventbriteapi.com/v3/events/search


            }
            catch(HttpRequestException e)
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