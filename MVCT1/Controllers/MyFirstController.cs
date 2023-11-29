using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCT1.Controllers
{
    public class MyFirstController : Controller
    {
        // GET: MyFirst
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            string name = "jack";
            ViewData["name"] = "jack";    // 键值对
            ViewBag.Name = "Tom";    // 对象 dynamic
            TempData["msg"] = "tempdata跨Action传递数据";
            return View();
        }


       public ActionResult EditUser()
        {


            return View();
        }



    }
}