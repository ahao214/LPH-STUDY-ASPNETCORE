using Blog.Application.Contract.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Blogs.Dto
{
    public class PageBlogDto:EntityDto
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// 浏览量
        /// </summary>
        public long PageView { get; set; }
        /// <summary>
        /// 点赞量
        /// </summary>
        public long Like { get; set; }
        /// <summary>
        /// 文章类型ID
        /// </summary>
        public Guid TypeId { get; set; }
        /// <summary>
        /// 作者ID
        /// </summary>
        public Guid AuthorId { get; set; }
        /// <summary>
        /// 导航属性用户
        /// </summary>
        public BlogUserDto? Author { get; set; }
        /// <summary>
        /// 导航属性文章类型
        /// </summary>
        public BlogTypeDto? Type { get; set; }





    }
}
