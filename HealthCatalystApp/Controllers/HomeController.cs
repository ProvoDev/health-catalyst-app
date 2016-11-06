using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthCatalystApp.Models;
using HealthCatalystApp.DAL;

namespace HealthCatalystApp.Controllers
{
    public class HomeController : Controller
    {
        private PeopleContext db = new PeopleContext();

        public ActionResult Index()
        {

            return View(db.People.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}