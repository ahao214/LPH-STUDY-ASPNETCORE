using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T7.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(string theme)
        {
            switch(theme)
            {    
                case "2":
                    return Content("body{background-color:cyan;}", "text/css");
                case "3":
                    return Content("body{background-color:blue;}", "text/css");
                default:
                    return Content("body{background-color:purple;}", "text/css");
            }

            return View();

        }








        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}