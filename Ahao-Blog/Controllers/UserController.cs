using Blog.Application.Contract.Dto;
using Blog.Application.Contract.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ahao_Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServer _userServer;

        public UserController(IUserServer userServer)
        {
            _userServer = userServer;
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task CreateUserAsync(CreateUserDto input)
        {
            await _userServer.CreateUserAsync(input);
        }




    }
}
