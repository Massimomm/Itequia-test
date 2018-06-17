using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Itequia.Controllers
{
    public class ExerciseController : Controller
    {
        
        public ActionResult Ejercicio1()
        {
            return View();
        }

        public ActionResult Ejercicio3()
        {
            return View();
        }

        public ActionResult AngularSumNumbers()
        {
            return View();
        }

        public ActionResult downloadScript()
        {
            return File("~/Documents/SQL-Script-Book-Author.sql", "application/sql");
        }

    }
}