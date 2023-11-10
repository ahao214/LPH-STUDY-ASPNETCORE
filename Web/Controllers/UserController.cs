using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Data;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public MyDbContext Context { get; set; }
        public UserController(MyDbContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = Context.Users.ToList();
            return Ok(users);
        }



    }
}
