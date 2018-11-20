﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "House on Haunted Hill" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Stephen Wright"},
                new Customer {Name = "Todd Buffington"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            

            return View(viewModel);
           
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


        [Route("movies/released/{year:regex(^\\d{4}$)}/{month:range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }

    }
}