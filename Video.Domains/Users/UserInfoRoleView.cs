﻿using Simple.EntityFramworkCore.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Domains.Users
{
    public class UserInfoRoleView : Entity
    {

        public UserInfoRoleView()
        {
            Role = new List<Role>();
        }

        /// <summary>
        /// 昵称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string? UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string? Password { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string? Avatar { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enable { get; set; } = true;

        public List<Role> Role { get; set; }

    }
}