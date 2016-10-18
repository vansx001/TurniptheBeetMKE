using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TurnipTheBeetMKE.Controllers
{
    public class HomeController : ApplicationBaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About() //MESSAGE FOR ABOUT PAGE
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() //MESSAGE FOR CONTACT PAGE
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}