using CrochetCatPause.Models;
using CrochetCatPause.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrochetCatPause.Controllers
{
    public class HomeController : Controller
    {
        private CatEntities db = new CatEntities();

        public ActionResult Index()
        {
            HomePageViewModel m = new HomePageViewModel();
            m.BlogPosts = db.posts.ToList();
            var shows = from s in db.shows
                        select s;
            shows = shows.Where(u => u.ShowDate > DateTime.Now);
            //m.UpcomingShows = db.shows.ToList();
            m.UpcomingShows = shows;
            
            return View(m);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Listen()
        {
            return View();
        }

    }
}
