using AutoMapper;
using Blog.Application.Contract.Blogs;
using Blog.Application.Contract.Blogs.Dto;
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
    /// 博客类型
    /// </summary>
    public class BlogTypeServer : IBlogTypeServer
    {
        private readonly BlogDbContext db;
        private readonly IMapper mp;
        public BlogTypeServer(BlogDbContext db, IMapper mp)
        {
            this.db = db;
            this.mp = mp;
        }

        public async Task CreateAsync(CreateBlogTypesDto input)
        {
            if (await db.BlogTypes.AnyAsync(x => x.Name == input.Name))
            {
                throw new BusinessException("已经存在相同博客类型");
            }

            var data = mp.Map<BlogTypes>(input);
            data.CreationTime = DateTime.Now;

            await db.BlogTypes.AddAsync(data);
            // 保存操作
            await db.SaveChangesAsync();
        }

        /// <inheritdoc>
        public async Task DeleteAsync(Guid id)
        {
            var type = await db.BlogTypes.FirstOrDefaultAsync(x => x.Id == id);
            if (type != null)
            {
                db.BlogTypes.Remove(type);
                await db.SaveChangesAsync();
            }

        }

        /// <summary>
        /// 更新博客类型
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task UpdateAsync(UpdateBlogTypeDto input)
        {
            var data = await db.BlogTypes.FirstOrDefaultAsync(x => x.Id == input.Id);
            data.Name = input.Name;
            db.BlogTypes.Update(data);
            await db.SaveChangesAsync();

        }
    }
}
