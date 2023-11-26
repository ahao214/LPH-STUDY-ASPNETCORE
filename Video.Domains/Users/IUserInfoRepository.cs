using Simple.EntityFramworkCore.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Video.Domains.Users
{
    public interface IUserInfoRepository
    {
        /// <summary>
        /// 获取用户详细信息 包括角色
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<UserInfoRoleView?> GetUserInfoRoleAsync(string userName, string password);

    }
}
