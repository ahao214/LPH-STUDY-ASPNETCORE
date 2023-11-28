using AutoMapper;
using Blog.Application.Contract.Blogs;
using Blog.Application.Contract.Blogs.Dto;
using Blog.Application.Users;
using Blog.EntityFrameworkCore;
using Blog.Module;
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


        /// <summary>
        /// 获取博客详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<BlogDto> GetAsync(Guid id)
        {
            var data = await db.Blogs.Where(x => x.Id == id)
                .AsNoTracking()     // 禁止跟踪查询
                .AsSplitQuery() // 拆分查询
                .Include(x => x.Type) // 导航属性查询类型信息
                .Include(x => x.Author) // 导航属性查询用户信息
                .FirstOrDefaultAsync();
            if (data == null)
            {
                throw new BusinessException("博客不存在", 404);
            }

            var dto = mp.Map<BlogDto>(data);
            // 获取博客点赞数量
            dto.Likes = await db.BlogLikes.LongCountAsync(x => x.BlogId == id);

            return dto;
        }

        /// <summary>
        /// 博客点赞
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task LikeAsync(Guid id)
        {
            var userId = curServer.GetUserId();
            var data = await db.BlogLikes.FirstOrDefaultAsync(x => x.BlogId == id && x.UserId == userId);
            if (data == null)
            {
                var like = new BlogLikes()
                {
                    UserId = userId,
                    BlogId = id,
                    CreationTime = DateTime.Now,
                };
                await db.BlogLikes.AddAsync(like);
                await db.SaveChangesAsync();
            }
        }
    }
}
