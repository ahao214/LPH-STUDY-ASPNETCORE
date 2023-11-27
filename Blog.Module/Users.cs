using Blog.Module.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Module
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Users : Entity
    {
        public Users()
        {
            CreationTime = DateTime.Now;
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string? Avatar { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

    }
}
