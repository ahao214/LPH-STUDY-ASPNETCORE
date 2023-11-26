using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Application.Contract.UserInfos.Dtos
{
    public class LoginInput
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string? UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string? Password { get; set; }
    }
}
