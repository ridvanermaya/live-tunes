using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LiveTunes.MVC.Controllers
{
    public class MusicPreferenceController : Controller
    {
        //Main View Where it Goes thru songs based on genres they like
        public ActionResult Index()
        {
            return View();
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