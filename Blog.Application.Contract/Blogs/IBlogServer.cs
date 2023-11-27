using Blog.Application.Contract.Blogs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Blogs
{
    /// <summary>
    /// 博客接口
    /// </summary>
    public interface IBlogServer
    {
        /// <summary>
        /// 创建博客文章
        /// </summary>
        /// <returns></returns>
        Task CreateBlogAsync(CreateBlogsDto input);




    }
}
