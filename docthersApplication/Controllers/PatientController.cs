using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using docthersApplication.Models;

namespace docthersApplication.Controllers
{
    public class PatientController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Patient
        public ActionResult PatientView()
        {
            return View(db.Patients.ToList());
        }
    }
}