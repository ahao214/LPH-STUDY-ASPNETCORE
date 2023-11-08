using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreLifetime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {

        [HttpGet("ok")]
        [HttpPost]
        public IActionResult GetOk() => Ok("返回成功ok");

        [HttpGet]
        public IActionResult AnotherOk(int a, int b) => Ok($"结果：{a}+ {b}={a + b}");

        // 数据类型约束
        [HttpGet("{id:int?}")]   //api/first/1
        public IActionResult Bad(int id) => Ok($"参数：{id}");


        //Restful 风格

        //api/users ...GET          全部用户
        //api/users/{id} ...GET     单个用户
        //api/users ...Post         创建用户
        //api/users/{id} ...Put     更新用户
        //api/users/{id} ...Delete  删除用户


        [HttpGet]
        public IActionResult Get() => Ok();

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok();

        [HttpPost]  // 创建用户
        public IActionResult Post(User model) => Ok();

        [HttpPut]   // 更新用户
        public IActionResult Put(int id,User model) => Ok();

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) => Ok();
    }

    public class User
    {}
}
