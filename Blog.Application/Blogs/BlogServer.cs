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

        /// <summary>
        /// 删除博客
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task DeleteAsync(Guid id)
        {
            var userId = curServer.GetUserId();
            // 获取博客并且只能删除自己的博客
            var data = await db.Blogs.FirstOrDefaultAsync(x => x.Id == id && x.AuthorId == userId);

            if (data != null)
            {
                db.Blogs.Remove(data);
                await db.SaveChangesAsync();
            }
        }

        /// <summary>
        /// 更新博客
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task UpdateAsync(CreateBlogsDto input)
        {
            var userId = curServer.GetUserId();
            var data = await db.Blogs.FirstOrDefaultAsync(x => x.AuthorId == userId);

            if (data == null)
            {
                throw new BusinessException("博客不存在");
            }
            // 将Input的数据映射到DATA
            mp.Map(input, data);
            
            db.Blogs.Update(data);
            await db.SaveChangesAsync();
        }
    }
}
