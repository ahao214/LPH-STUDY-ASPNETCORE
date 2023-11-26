using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Video.Application.Contract.UserInfos.Dtos;

namespace Video.Application.Contract.UserInfos
{
    public interface IUserInfoService
    {
        /// <summary>
        /// 根据账号和密码获取用户信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<UserInfoRoleDto> LoginAsync(LoginInput input);

    }
}
