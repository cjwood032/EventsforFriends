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
        public IActionResult Create()
        {
            ViewBag.Interests = db.interests.Where(i => i.UserID == null).ToList();
            ViewBag.Groups = db.groups.Where(g => g.OwnerID == 1).ToList(); //need to update when user login occurs.
            ViewBag.Groups.Insert(0,new Group() { GroupName = "No Group" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(Shindig shindig)
        {
            if(ModelState.IsValid)
            {
                shindig.AvailableSpots = (short)(shindig.Openings -1);
                if(shindig.GroupID==0)
                {
                    shindig.GroupID = null;
                }
                shindig.host = db.users.Where(user => user.UserID == 1).FirstOrDefault();//need to update when logins
                db.shindigs.Add(shindig);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Interests = db.interests.Where(i => i.UserID == null).ToList();
                return View();
            }
        }
    }
}
