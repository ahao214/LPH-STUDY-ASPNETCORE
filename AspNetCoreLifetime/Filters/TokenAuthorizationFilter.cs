using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
namespace AspNetCoreLifetime.Filters
{
    public class TokenAuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(context .ActionDescriptor .EndpointMetadata.Any (m=>m.GetType()==typeof(AllowAnonymousAttribute)))
            {
                return;
            }

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
