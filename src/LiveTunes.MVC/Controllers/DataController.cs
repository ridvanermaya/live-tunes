using System.Linq;
using LiveTunes.MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace LiveTunes.MVC.Controllers
{
    public class DataController : Controller
    {
        public DataController(ApplicationDbContext context)
        {
            var e = context.Events.Where(x => x.EventId == 5).FirstOrDefault();
           // e.Likes.ToList();
        }

    }
}