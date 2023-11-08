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

    }
}
