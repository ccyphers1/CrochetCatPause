using CrochetCatPause.Models;
using CrochetCatPause.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactMessage message)
        {
            if (!ModelState.IsValid) return RedirectToAction("Listen");

            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient();

            mail.From = new MailAddress("crochetcatpausesite@gmail.com", "CCP Website");
            mail.To.Add(new MailAddress("chancecyphers@gmail.com"));
            if (message.Subject == null) mail.Subject = "Too cool for a subject";
            mail.Subject = message.Subject;
            mail.Body = message.Body + Environment.NewLine + "Return Email: " + message.ReturnEmail;

            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("crochetcatpausesite@gmail.com", "ultimatepassword");
            client.EnableSsl = true;
            client.Send(mail);

            return RedirectToAction("Thanks");
        }

        public ActionResult Thanks()
        {
            return View();
        }
    }
}
