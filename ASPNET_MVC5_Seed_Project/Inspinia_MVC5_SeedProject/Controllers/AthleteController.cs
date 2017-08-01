using Inspinia_MVC5_SeedProject.DAL;
using Inspinia_MVC5_SeedProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Inspinia_MVC5_SeedProject.Controllers
{
    public class AthleteController : Controller
    {
       private ResetContext db = new ResetContext();

        // Returns all athletes in the database
        // GET: Athlete
        public ActionResult Index()
        {
            var athletes = db.Athletes.ToList();

            return View(athletes);
        }
        // Takes in the id of the athlete that you want to view and does some varification and then reutrns the athlete into the details
        public ActionResult Details (int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           // Find the athlete in the database 
            Athlete athlete = db.Athletes.Find(id);

            if (athlete == null)
            {
                return HttpNotFound();
            }
            return View(athlete);
        }

        // Action that returns the view for creating an athlete
        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // Action that is called when an athlete is created
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name, Sex, SocialSecurity, Sport, Team")]Athlete athlete)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Athletes.Add(athlete);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(athlete);
        }

        // Returns the view for editing an athlete 
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Athlete athlete = db.Athletes.Find(id);
            if (athlete == null)
            {
                return HttpNotFound();
            }
            return View(athlete);
        }

        // Action that does the edit for an athlete
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var athleteToUpdate = db.Athletes.Find(id);
            if (TryUpdateModel(athleteToUpdate, "",
               new string[] { "Name", "Sex", "SocialSecurity", "Sport", "Team" }))
            {
                try
                {
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(athleteToUpdate);
        }

        // Action called to return the view for deleting a specific athlete
        // GET: Course/Delete/5
        // GET: Student/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Athlete athlete = db.Athletes.Find(id);
            if (athlete == null)
            {
                return HttpNotFound();
            }
            return View(athlete);
        }


        // Action that performs the deleting of an athlete
        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Athlete athlete = db.Athletes.Find(id);
                db.Athletes.Remove(athlete);
                db.SaveChanges();
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }
    }
}