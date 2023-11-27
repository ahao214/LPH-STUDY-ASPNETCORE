using AutoMapper;
using Blog.Application.Contract.Blogs;
using Blog.Application.Contract.Blogs.Dto;
using Blog.EntityFrameworkCore;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Blogs
{
    /// <summary>
    /// 博客接口实现类
    /// </summary>
    public class BlogServer : IBlogServer
    {
        private readonly BlogDbContext db;
        private readonly IMapper mp;
        private readonly CurrentServer curServer;
        public BlogServer(BlogDbContext blogDbContext, IMapper mapper, CurrentServer currentServer)
        {
            db = blogDbContext;
            mp = mapper;
            curServer = currentServer;
        }

        /// <summary>
        /// 创建博客文章
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="BusinessException"></exception>
        public async Task CreateBlogAsync(CreateBlogsDto input)
        {
            var userId = curServer.GetUserId();
            // 查询数据库是否存在指定博客文章类型
            if (await db.BlogTypes.AnyAsync(x => x.Id == input.TypeId))
            {
                throw new BusinessException("博客文章类型不存在");
            }

            var data = mp.Map<Module.Blogs>(input);
            data.AuthorId = userId;
            await db.AddAsync(data);
            await db.SaveChangesAsync();


        }
    }
}
