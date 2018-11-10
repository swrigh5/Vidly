using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "House on Haunted Hill" };
            return View(movie);
           
        }


        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }


        // movies 
        public ActionResult Index(int? pageIndex, string sortby)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortby))
                sortby = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortby));            
        }

        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }

    }
}