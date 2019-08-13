using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiveTunes.MVC.Models;
using System.Net.Http.Headers;
using System.Diagnostics;
=======
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
>>>>>>> b44727f0f8937937f19b9ff663f7f708175d47f2

namespace LiveTunes.MVC.Controllers
{
    public class EventController : Controller
    {
<<<<<<< HEAD
        private static readonly HttpClient client;
        /*public IEnumerable<Event> events;*/
        static EventController()
        {
            client = new HttpClient();    
        }

        static async Task GetEvents()
        {
            try
            {
                

                var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://www.eventbriteapi.com/v3/events/search?location.address=vancovuer&location.within=10km&expand=venue");
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await client.SendAsync(requestMessage);

                Debug.WriteLine(response.Content.ReadAsStringAsync());

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