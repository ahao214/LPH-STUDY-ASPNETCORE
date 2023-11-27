using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface ICurrentServer
    {
        ///// <summary>
        ///// 是否授权
        ///// </summary>
        ///// <returns></returns>
        //bool? IsAuthenticated();
        ///// <summary>
        ///// 用户ID
        ///// </summary>
        ///// <returns></returns>
        //Guid? UserId();
        ///// <summary>
        ///// 获取用户ID
        ///// </summary>
        ///// <returns></returns>
        //Guid GetUserId();
        ///// <summary>
        ///// 获取用户信息
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <returns></returns>
        //T? UserInfo<T>();

    }

    public class CurrentServer : ICurrentServer
    {
        //private readonly IHttpContextAccessor _httpContextAccessor;
        //private readonly TokenOptions _tokenOptions;

        //public CurrentServer(IHttpContextAccessor httpContextAccessor, IOptions<TokenOptions> tokenOptions)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //    _tokenOptions = tokenOptions.Value;
        //}

        //public Guid GetUserId()
        //{
        //    var userId = UserId();
        //    if (userId == null)
        //        throw new BusinessException("账号未登录");

        //    return (Guid)userId;
        //}

        //public bool? IsAuthenticated()
        //{
        //    return _httpContextAccessor.HttpContext?.User.Identity?.IsAuthenticated;
        //}

        //public Guid? UserId()
        //{
        //    var id = GetClaimValueByType(Constant.Id)?.FirstOrDefault();
        //    if(string .IsNullOrEmpty (id ))
        //    {
        //        return default;
        //    }
        //    return Guid.Parse(id);

        //}

        //public T? UserInfo<T>()
        //{
        //    var userInfo = GetClaimValueByType(Constant.User)?.FirstOrDefault();
        //    return string .IsNullOrEmpty (userInfo )? default :JsonConverter.DeserializeObject<T>(userInfo);

        //}

        //private IEnumerable<string>? GetClaimValueByType(string claimType)
        //{
        //    return _httpContextAccessor.HttpContext?.User.Claims?.Where(item => item.Type == claimType).Select(item => item.Value);
        //}
    }
}
