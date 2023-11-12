using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YDT_MongoDEbusiness.Models;
using MongoDB.Driver;


namespace YDT_MongoDEbusiness.Controllers
{
    /// <summary>
    /// 订单控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IMongoCollection<Order> orders;
        public OrderController(MongoDbDatabase mongoDatabase)
        {
            //3.获取数据库集合
            orders = mongoDatabase.database.GetCollection<Order>("order");
        }


        /// <summary>
        /// 添加订单方法
        /// </summary>
        /// <returns></returns>
        [HttpPost(Name = "AddOrder")]
        public string AddOrder(Order order)
        {
            //4.存储用户数据到集合
            orders.InsertOne(order);

            return "添加成功";
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetOrder")]
        public List<Order> GetOrder()
        {
            //4.存储用户数据到集合
            var orderList = orders.Find(o => o.Id == 1).ToList();

            return orderList;
        }

    }
}
