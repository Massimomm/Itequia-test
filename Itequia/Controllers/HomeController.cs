using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Itequia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We are used to design clean code.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here you can find the company's contact page.";

            return View();
        }
    }
}