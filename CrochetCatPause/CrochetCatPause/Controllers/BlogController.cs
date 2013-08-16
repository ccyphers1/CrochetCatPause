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
    public class BlogController : Controller
    {
        private CatEntities db = new CatEntities();

        public ActionResult Index()
        {
            return View(db.posts.ToList());
        }

        public ActionResult Details(int id = 0)
        {
            BlogPost blogpost = db.posts.Find(id);
            if (blogpost == null)
            {
                return HttpNotFound();
            }
            return View(blogpost);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BlogPost blogpost)
        {
            blogpost.Published = true;
            blogpost.PostTime = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.posts.Add(blogpost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blogpost);
        }

        public ActionResult Edit(int id = 0)
        {
            BlogPost blogpost = db.posts.Find(id);
            if (blogpost == null)
            {
                return HttpNotFound();
            }
            return View(blogpost);
        }

        [HttpPost]
        public ActionResult Edit(BlogPost blogpost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blogpost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blogpost);
        }

        public ActionResult Delete(int id = 0)
        {
            BlogPost blogpost = db.posts.Find(id);
            if (blogpost == null)
            {
                return HttpNotFound();
            }
            return View(blogpost);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            BlogPost blogpost = db.posts.Find(id);
            db.posts.Remove(blogpost);
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