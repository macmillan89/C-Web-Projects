using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkyMovies.Models;

namespace SkyMovies.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult ListCustomers()
        {
            
            var customers = new Customers() { Name = "Macmillan", Surname = "Nyamukondiwa"};
            
            return View(customers);
        }
    }
}