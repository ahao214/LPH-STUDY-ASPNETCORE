using Ahao_Blog.Options;
using Blog.Application.Contract.User;
using Blog.Application.Contract.User.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Pomelo.EntityFrameworkCore.MySql.Query.Internal;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Ahao_Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServer _userServer;
        private readonly JwtOptions _jwtOptions;

        public UserController(IUserServer userServer, IOptions<JwtOptions> jwtOptions)
        {
            _userServer = userServer;
            _jwtOptions = jwtOptions.Value;
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

        [HttpPost("login")]
        public async Task<string> LoginAsync(LoginDto input)
        {
            var user = await _userServer.LoginAsync(input);

            var claims = new[]
            {
                new Claim ("Guid",user.Id .ToString ()),
                new Claim(ClaimTypes.Role ,user .Role )
            };

            // 加密
            var cred = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey!)), SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                _jwtOptions.Issuer,   // 签发者
                _jwtOptions.Audience, // 接收者
                claims,    // payload
                expires: DateTime.Now.AddMilliseconds(_jwtOptions.ExpireMinute),    // 过期时间
                signingCredentials: cred);   // 令牌

            var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            return token;
        }





    }
}
