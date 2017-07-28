using Inspinia_MVC5_SeedProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inspinia_MVC5_SeedProject.Controllers
{
    public class AthleteController : Controller
    {
       private ResetContext db = new ResetContext();

            
        // GET: Athlete
        public ActionResult Index()
        {
            var students = db.Athletes.ToList();

            return View(students);
        }
        
    }
}