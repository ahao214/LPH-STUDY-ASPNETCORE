using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Dto
{
    public class CreateUserDto
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [MinLength(6,ErrorMessage ="用户名长度不能小于6位")]
        public string UserName { get; set; } = null!;
        /// <summary>
        /// 密码
        /// </summary>
        [MinLength(6, ErrorMessage = "密码长度不能小于6位")]
        public string Password { get; set; } = null!;
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
