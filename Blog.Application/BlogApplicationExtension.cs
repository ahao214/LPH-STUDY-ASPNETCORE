using Blog.Application.Blogs;
using Blog.Application.Contract.Blogs;
using Blog.Application.Contract.User;
using Blog.Application.Users;
using Blog.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application
{
    public static class BlogApplicationExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            // 注入AutoMapper
            services.AddAutoMapper(typeof(BlogApplicationExtension));

            // 注入User服务
            services.AddTransient<IUserServer, UserServer>();
            // 注入Blog服务
            services.AddTransient<IBlogServer, BlogServer>();
            // 注入BlogType服务
            services.AddTransient<IBlogTypeServer, BlogTypeServer>();



            services.AddEntityFrameworkCore();
        }

    }
}
