using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YDT_EBusiness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        
        /// <summary>
        /// 查询商品接口
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name ="GetProduct")]
        public string GetProduct()
        {
            // 日志
            _logger.LogInformation("查询商品成功");

            return "查询商品成功";
        }




    }
}
