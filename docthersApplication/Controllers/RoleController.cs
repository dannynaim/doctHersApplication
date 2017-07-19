using docthersApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace docthersApplication.Controllers
{
    public class RoleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext(); 
        // GET: Role
        public ActionResult RoleView()
        {
            return View(db.Users.ToList());
        }
    }
}