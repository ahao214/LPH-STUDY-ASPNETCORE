﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace AspNetCoreLifetime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        public IResult Login([FromForm]LoginModel model)
        {
            JwtSecurityToken securityToken = new(claims: new[]
            {
                new Claim(ClaimTypes.Name,model.UserName)
            });
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            var token = handler .WriteToken(securityToken);
            return Results.Ok(token);
        }

        [HttpGet]
        public IResult Hello() => Results.Ok(User.Identity.Name);

    }



    public class LoginModel
    {
        public string? UserName     { get; set; }
        public string? Password { get; set; }
    }
}
