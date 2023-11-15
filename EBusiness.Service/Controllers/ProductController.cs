using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EBusiness.Service.Models;
using EBusiness.Service.Services;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace EBusiness.Service.Controllers
{
    /// <summary>
    /// 商品控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>>GetProducts()
        {
            return _productService.GetProducts().ToList();
        }
    




    }
}
