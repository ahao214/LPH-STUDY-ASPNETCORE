using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using T6_1.Models;



namespace T6_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        #region 用来获取appsetting.json里面的redis信息

        IConfiguration _config;

        #endregion

        RedisCache redisCache;


        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _config = configuration;

            #region redis客户端链接

            var options = new RedisCacheOptions();
            options.Configuration = _config.GetSection("redis").Get<RedisInfo>().DB;
            options.InstanceName = _config.GetSection("redis").Get<RedisInfo>().Name;

            redisCache = new RedisCache(options);

            #endregion
        }

        public IActionResult Index()
        {
            // redis的写入
            redisCache.SetString("timeNow", DateTime.Now.ToString());

            return View();
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
