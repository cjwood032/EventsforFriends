using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Events.Models;

namespace Events.Controllers
{
    
    public class ShindigsController : Controller
    {
        EventDbContext db = new EventDbContext();
        public IActionResult Index()
        {
            List<Shindig> shindigs = db.shindigs.ToList();
            return View(shindigs);
        }
        public IActionResult Details(long id)
        {
            Shindig shindig = db.shindigs.Where(s => s.ShindigID == id).FirstOrDefault();
            return View(shindig);
        }
    }
}
