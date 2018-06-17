using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DALLayer.Interface;


namespace Itequia.Controllers
{
    public class BookController : Controller
    {
        private IBooksAuthors _booksauthors;

        public BookController(IBooksAuthors booksauthors)
        {
            _booksauthors = booksauthors;
        }

        // GET: Book
        public ActionResult books()
        {
            return View(_booksauthors.getAllABooks());
        }

        public ActionResult booksAuthors()
        {
            return View(_booksauthors.getAllABooksAuthors());
        }

        public ActionResult FirstPublished()
        {
            return View(_booksauthors.getFirstPublished());
        }

    }
}