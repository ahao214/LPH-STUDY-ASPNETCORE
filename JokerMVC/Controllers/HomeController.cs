using JokerMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Transactions;

namespace JokerMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [Authorize(Roles ="admin")]
        public IActionResult Index(int? id)
        {
            ViewData["name"] = "ViewData-Joker编程";
            ViewBag.name = "ViewBag-joker";
            Student stu = new Student() { Id = 1, Name = "Joker" };
            //return Json(stu);
            return View(stu);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
