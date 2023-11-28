﻿using Blog.Application.Contract.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Blogs.Dto
{
    public class BlogUserDto:EntityDto
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string? Avatar {  get; set; } 
        /// <summary>
        /// 邮箱
        /// </summary>
        public string? Email { get; set; }
    }
}
