using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using T2.Models;
using T2.Utils;
using Microsoft.Extensions.Configuration;



namespace T2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService _services;
        private IConfiguration _config;

        public HomeController(ILogger<HomeController> logger,IProductService services, IConfiguration config)
        {
            _logger = logger;
            _logger.LogInformation("...构造函数中依赖注入...");
            _services = _services;
            _config = config;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("...进入Index视图...");
            // 获取appsettings.json里面的节点信息
           SiteConfig sc= _config.GetSection("SiteConfig").Get<SiteConfig>();

            ViewBag.SiteConfig = sc;


            var list = new List<Goods>()
            {
               new Goods(1,"苹果",10),
               new Goods(2,"凤梨",12),
               new Goods(3,"橘子",23),
               new Goods(4,"香蕉",4),
            };

            //var list = _services.GetAllGoods();

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
