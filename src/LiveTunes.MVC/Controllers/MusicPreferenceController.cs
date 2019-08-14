using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using LiveTunes.MVC.Data;
using LiveTunes.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            // GetSongs("Rock");
            _context = context;
            suggestedSongs = new JArray();
        }

        public JToken GetSuggestedSongs()
        {
            return suggestedSongs;
        }

        // public async void GetSongs(string genre)
        // {
        //     client.DefaultRequestHeaders.Add(new MediaTypeWithQualityHeaderValue("jsonp"));
        //     HttpResponseMessage response = await client.GetAsync("http://itunes.apple.com/search?term=Jack+Johnson?callback=?");
        //     suggestedSongs = await response.Content.ReadAsAsync<String>();
        // }

        //Main View Where it Goes thru songs based on genres they like
        public ActionResult Index()
        {
            return View(suggestedSongs);
        }

        public async Task Create(string artist, string songName, string genre)
        {
            MusicPreference preference = new MusicPreference();
            preference.SongName = songName;
            preference.ArtistName = artist;
            preference.Genre = genre;
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _context.UserProfiles.Where(x => x.UserId == userid).FirstOrDefaultAsync();
            preference.UserId = user.UserProfileId;
            preference.User = user;
            await _context.MusicPreferences.AddAsync(preference);
            await _context.SaveChangesAsync();
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