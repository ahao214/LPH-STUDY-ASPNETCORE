using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Blogs.Dto
{
    /// <summary>
    /// 博客通用类型
    /// </summary>
    public  class BlogDto
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// 文章类型ID
        /// </summary>
        public Guid TypeId { get; set; }
       
    }
}
