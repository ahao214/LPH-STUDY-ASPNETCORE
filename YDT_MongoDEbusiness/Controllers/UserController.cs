using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YDT_MongoDEbusiness.Models;
using MongoDB.Driver;


namespace YDT_MongoDEbusiness.Controllers
{
    /// <summary>
    /// 用户控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        /// <summary>
        /// 添加用户方法
        /// </summary>
        /// <returns></returns>
        [HttpPost(Name = "AddUser")]
        public string AddUser(User user)
        {
            //1.创建MongoClient
            MongoClient mongoClient = new MongoClient("mongodb://localhost:2222");

            //2.获取数据库            
            var database = mongoClient.GetDatabase("数据库名称");

            //3.获取数据库集合
            var users = database.GetCollection<User>("user");

            //4.存储用户数据到集合
            users.InsertOne(user);

            return "添加成功";
        }

        /// <summary>
        /// 查询用户
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetUser")]
        public List <User> GetUser()
        {
            //1.创建MongoClient
            MongoClient mongoClient = new MongoClient("mongodb://localhost:2222");

            //2.获取数据库            
            var database = mongoClient.GetDatabase("数据库名称");

            //3.获取数据库集合
            var users = database.GetCollection<User>("user");

            //4.存储用户数据到集合
            var userList = users.Find(u => u.Id == 1).ToList();

            return userList;
        }

    }
}
