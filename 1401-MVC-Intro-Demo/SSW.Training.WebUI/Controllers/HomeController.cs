using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSW.Training.WebUI.Models;

namespace SSW.Training.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var customer = new Customer{FirstName = "Adam", LastName = "Stephensen"};

            return View(customer);
        }

    }
}
