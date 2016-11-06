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

            return View();
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


        /// <summary>
        /// This controller is called to return JSON containing
        /// search restuls form AJAX call.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult SearchResults(string id)
        {
            var people = from m in db.People select m;

            if (!String.IsNullOrEmpty(id))
            {
                people = people.Where(s => s.first_name.Contains(id) || s.last_name.Contains(id));

            }

            //Returns JSON containing search results
            return Json(people.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}