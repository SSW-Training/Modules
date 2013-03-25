using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSW.Training.WebUI.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is the default action method";
        }

        public string Welcome(string target)
        {
            return HttpUtility.HtmlEncode(string.Format("Hello {0} !" ,target));
        }

        public ActionResult Thank(string target)
        {

            ViewBag.Message = string.Format("Hello {0}!", target);
            ViewBag.RepeatCount = 5;

            return View();
        }
    }
}


