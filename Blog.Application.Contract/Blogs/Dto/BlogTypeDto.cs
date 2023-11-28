using Blog.Application.Contract.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Blogs.Dto
{
    /// <summary>
    /// 博客类型
    /// </summary>
    public class BlogTypeDto:EntityDto
    {
        /// <summary>
        /// 类型名称
        /// </summary>
        public string Name { get; set; } = null!;
    }
}
