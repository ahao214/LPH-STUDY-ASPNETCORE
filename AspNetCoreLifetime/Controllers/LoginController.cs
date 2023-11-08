using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreLifetime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IResult Login([FromForm]LoginModel model)
        {
            return Results.Ok(model);
        }

    }



    public class LoginModel
    {
        public string? UserName     { get; set; }
        public string? Password { get; set; }
    }
}
