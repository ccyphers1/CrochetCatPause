using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrochetCatPause.Models;

namespace CrochetCatPause.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ShowController : Controller
    {
        private CatEntities db = new CatEntities();

        public ActionResult Index()
        {
            return View(db.shows.ToList());
        }

        public ActionResult Details(int id = 0)
        {
            UpcomingShow upcomingshow = db.shows.Find(id);
            if (upcomingshow == null)
            {
                return HttpNotFound();
            }
            return View(upcomingshow);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UpcomingShow upcomingshow)
        {
            if (ModelState.IsValid)
            {
                db.shows.Add(upcomingshow);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(upcomingshow);
        }

        public ActionResult Edit(int id = 0)
        {
            UpcomingShow upcomingshow = db.shows.Find(id);
            if (upcomingshow == null)
            {
                return HttpNotFound();
            }
            return View(upcomingshow);
        }

        [HttpPost]
        public ActionResult Edit(UpcomingShow upcomingshow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(upcomingshow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(upcomingshow);
        }

        public ActionResult Delete(int id = 0)
        {
            UpcomingShow upcomingshow = db.shows.Find(id);
            if (upcomingshow == null)
            {
                return HttpNotFound();
            }
            return View(upcomingshow);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            UpcomingShow upcomingshow = db.shows.Find(id);
            db.shows.Remove(upcomingshow);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}