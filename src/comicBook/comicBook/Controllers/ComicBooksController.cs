using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comicBook.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBooks
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");
            }
            return Content("Hello from comic books controller!");
        }
    }
}