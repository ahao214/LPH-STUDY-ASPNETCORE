using Blog.Application.Contract.Blogs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Blogs
{
    public interface IBlogTypeServer
    {
        /// <summary>
        /// 创建博客类型
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateAsync(CreateBlogTypesDto input);
        /// <summary>
        /// 删除博客类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid id);
        /// <summary>
        /// 更新博客类型
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateAsync(UpdateBlogTypeDto input);



    }
}
