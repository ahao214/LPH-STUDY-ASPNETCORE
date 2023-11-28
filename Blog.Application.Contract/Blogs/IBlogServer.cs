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
        /// <summary>
        /// 删除博客
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid id);
        /// <summary>
        /// 更新博客
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateAsync(CreateBlogsDto input);
        /// <summary>
        /// 获取博客详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<BlogDto> GetAsync(Guid id);

    }
}
