using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using T2.Models;
using T2.Utils;




namespace T2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService _services;


        public HomeController(ILogger<HomeController> logger,IProductService services)
        {
            _logger = logger;
            _services = _services;
        }

        public IActionResult Index()
        {
            //var list = new List<Goods>()
            //{
            //   new Goods(1,"苹果",10),
            //   new Goods(2,"凤梨",12),
            //   new Goods(3,"橘子",23),
            //   new Goods(4,"香蕉",4),
            //};

            var list = _services.GetAllGoods();



            return View(list);
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
}
