using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return new RedirectResult("/");
            }
            return Content("Hello from the CBC!");
            //this code operates the same as the line above.
            //return new ContentResult()
            //{
            //   Content = "Hello fromthe CBC!"
            //};
        }
    }
}