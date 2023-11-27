using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;


namespace Infrastructure
{
    
    public class CurrentServer
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly TokenOptions _tokenOptions;

        public CurrentServer(IHttpContextAccessor httpContextAccessor, IOptions<TokenOptions> tokenOptions)
        {
            _httpContextAccessor = httpContextAccessor;
            _tokenOptions = tokenOptions.Value;
        }

        /// <summary>
        /// 是否授权
        /// </summary>
        /// <returns></returns>
        public bool? IsAuthenticated()
        {
            return _httpContextAccessor.HttpContext?.User.Identity?.IsAuthenticated;
        }

        /// <summary>
        /// 获取用户ID
        /// </summary>
        /// <returns></returns>
        /// <exception cref="BusinessException"></exception>
        public Guid GetUserId()
        {
            var id = GetClaimValueByType(Constant.Id)?.FirstOrDefault();
            if (id == null || string.IsNullOrEmpty(id))
                throw new BusinessException("账号未登录", 401);
            return Guid.Parse(id);
        }

        private IEnumerable<string>? GetClaimValueByType(string claimType)
        {
            return _httpContextAccessor.HttpContext?.User.Claims?.Where(item => item.Type == claimType).Select(item => item.Value);
        }
    }
}


public static class CurrentExtension
{
    public static void AddCurrent(this IServiceCollection services
        )
    {
        services .AddTransient <IHttpContextAccessor, HttpContextAccessor>();
        services.AddTransient<CurrentServer>();
    }

}