using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;
using System.Text.Json;



namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Test()
        {
            List<TestModel> list = new List<TestModel>();
            list.Add(new TestModel() { Id = 1, Name = "jack", Description = "aaa", CreateTime = DateTime.Now });
            list.Add(new TestModel() { Id = 2, Name = "kutng", Description = "dd", CreateTime = DateTime.Now });

            string str = JsonSerializer.Serialize(list);
            // 反序列化
            var list2 = JsonSerializer.Deserialize<TestModel>(str);
            // 序列化
            return JsonSerializer.Serialize(list);
        }

        [HttpGet]
        public List<TestModel> Get()
        {
            List<TestModel> list = new List<TestModel>();
            list.Add(new TestModel() { Id = 1, Name = "jack", Description = "aaa", CreateTime = DateTime.Now });
            list.Add(new TestModel() { Id = 2, Name = "kutng", Description = "dd", CreateTime = DateTime.Now });

            return list;

        }


        [HttpPost]
        public string GetSearch(SearchReq input)
        {
            return "ok" + input.Name;
        }



    }
}
