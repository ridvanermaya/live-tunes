using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using LiveTunes.MVC.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace LiveTunes.MVC.Controllers
{
    public class MusicPreferenceController : Controller
    {
        private HttpClient client;
        private JToken suggestedSongs;
        private ApplicationDbContext _context;

        public MusicPreferenceController(ApplicationDbContext context)
        {
            client = new HttpClient();
            GetSongs("Rock");
            _context = context;
            suggestedSongs = new JArray();
        }

        public JToken GetSuggestedSongs()
        {
            return suggestedSongs;
        }

        public async void GetSongs(string genre)
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("jsonp"));
            HttpResponseMessage response = await client.GetAsync("http://itunes.apple.com/search?term=Jack+Johnson");
            suggestedSongs = await response.Content.ReadAsAsync<String>();
        }

        //Main View Where it Goes thru songs based on genres they like
        public ActionResult Index()
        {
            return View(suggestedSongs);
        }

        public ActionResult Like()
        {
            return RedirectToAction("Index");
        }


        //Will write Some Jquery to go along with this
        //Pretty Much adding the song liked to MusicPreferences table
        [HttpPost]
        public void Like(JsonResult Song)
        {
            //return RedirectToAction(nameof(Index));
        }

        // GET: MusicPreference/Details/5
        // Would get music preferences by percentage of genre
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}