using Events.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Controllers
{
    public class GroupsController : Controller
    {
        EventDbContext db = new EventDbContext();
        public IActionResult Index()
        {
            int user_id = 1;
            List<Group> groups = db.groups.Where(g => g.OwnerID == user_id).ToList();
            return View(groups);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Group group, List<string> emailList)
        {
            var value1 = Request.Form.Keys;
            var item2 = Request.Form;
            return RedirectToAction("Index");
        }
    }
}
