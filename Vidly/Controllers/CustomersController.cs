using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ////display all customers Index/Customers
            //with all links for each customer taking them to their page @ Customers/Detail/(CustomerNumber)
            //If there are no customers, display text stating so

            var customers = GetCustomers();

            return View(customers);
        }


        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(d => d.Id == id);
            //create a for loop instead
            //foreach (var customer in GetCustomers())
            //{
            //    if (customer == null)
            //        return HttpNotFound();
            //    else
            //    {
            //        return View(customer);
            //    }
           
            //}

            return View(customer);
       

        }

        private IEnumerable<customers> GetCustomers()
        {
            return new List<customers>
            {
                new customers { Id = 1, Name = "Stephen Wright" },
                new customers { Id = 2, Name = "Todd Buffington" },
                new customers { Id = 3, Name = "Fred Savage" }
            };
        }

    }
}