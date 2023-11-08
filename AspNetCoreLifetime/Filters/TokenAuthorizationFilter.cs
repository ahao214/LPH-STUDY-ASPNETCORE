using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace AspNetCoreLifetime.Filters
{
    public class TokenAuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var token = context.HttpContext.Request.Headers.Authorization;
            if (string.IsNullOrEmpty(token))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            JwtSecurityTokenHandler handler = new();
            try
            {
                var jwt = handler.ReadJwtToken(token);
                var identity = new ClaimsIdentity(jwt.Claims);
                context.HttpContext.User = new(identity);
            }
            catch (Exception ex)
            {
                context.Result = new UnauthorizedResult();
                return;                
            }
        }
    }
}
