using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;




namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Test()
        {
            return "ok";
        }

        [HttpGet]
        public List<TestModel> Get()
        {
            List<TestModel> list = new List<TestModel>();
            list.Add(new TestModel() { Id = 1, Name = "jack", Description = "aaa", CreateTime = DateTime.Now });
            list.Add(new TestModel() { Id = 2, Name = "kutng", Description = "dd", CreateTime = DateTime.Now });

            return list;

        }

    }
}
