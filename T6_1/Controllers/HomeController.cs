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
using Newtonsoft.Json;



namespace T6_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        #region 用来获取appsetting.json里面的redis信息

        IConfiguration _config;

        #endregion

        RedisCache redisClient;


        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _config = configuration;

            #region redis客户端链接

            var options = new RedisCacheOptions();
            options.Configuration = _config.GetSection("redis").Get<RedisInfo>().DB;
            options.InstanceName = _config.GetSection("redis").Get<RedisInfo>().Name;

            redisClient = new RedisCache(options);

            #endregion
        }

        public IActionResult Index()
        {
            // redis的写入
            redisClient.SetString("timeNow", DateTime.Now.ToString());


            Product p = new Product()
            {
                ID = 1,
                ProductName = "手机",
                ProductPrice = 344.56
            };

            // 序列化
            string pStr = JsonConvert.SerializeObject(p);
            redisClient.SetString("p", pStr);

            return View();
        }

        /// <summary>
        /// 读取redis中的数据
        /// </summary>
        /// <returns></returns>
        public IActionResult ReadData()
        {
            // redis 读
            ViewBag.TimeNow = redisClient.GetString("timeNow");

            // redis 读对象
            string pStr = redisClient.GetString("p");
            // 反序列化
            ViewBag.p = JsonConvert.DeserializeObject<Product>(pStr);

            return View("Index");
        }

        /// <summary>
        /// 删除redis中的数据
        /// </summary>
        /// <returns></returns>
        public IActionResult DelData()
        {
            // redis 删
            redisClient.Remove("timeNow");
            return View("Index");
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
