using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrizzlyGamesSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "More information about our great company.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GGTV()
        {
            ViewBag.Message = "Come watch our Live Stream!";

            return View();
        }

        public ActionResult Game()
        {
            ViewBag.Message = "Check out our games!";

            return View();
        }

        public ActionResult Video()
        {
            ViewBag.Message = "Watch your favourite hosts play through your favourite games!";

            return View();
        }

        public ActionResult Social()
        {
            ViewBag.Message = "Stay connected to our social accounts.";

            return View();
        }  
    }
}