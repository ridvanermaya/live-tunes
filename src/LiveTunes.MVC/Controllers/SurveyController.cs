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
            return View();
        }
        
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Survey/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Survey/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Survey/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Survey/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Survey/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Survey/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}