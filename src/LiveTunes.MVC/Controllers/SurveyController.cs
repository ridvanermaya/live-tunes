using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiveTunes.MVC.Models;
using LiveTunes.MVC.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace LiveTunes.MVC.Controllers
{
    public class SurveyController : Controller
    {
        private ApplicationDbContext _context;
        private HttpClient client;
        //private JToken suggestedSongs;
        SurveyController(ApplicationDbContext context)
        {
            client = new HttpClient();
            _context = context;
        }

        // GET: Survey
        public ActionResult Index()
        {
            
            //string find = User.Identity.UserId;
            //UserProfile employee = _context.UserProfiles.Where(x => x.UserId == find).FirstOrDefault();
            return View("Create");
        }
        
        // GET: Survey/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Survey/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Survey survey)
        {
            _context.AddAsync(survey);
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}