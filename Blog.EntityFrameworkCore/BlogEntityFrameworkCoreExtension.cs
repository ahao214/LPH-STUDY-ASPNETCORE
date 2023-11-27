using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntityFrameworkCore
{
    public static class BlogEntityFrameworkCoreExtension
    {
        public static void AddEntityFrameworkCore(this IServiceCollection services)
        {
            var configure = services.BuildServiceProvider().GetRequiredService<IConfiguration>();

            services.AddDbContext<BlogDbContext>(options => options.UseMySql(configure["ConnectionStrings:Default"],new MySqlServerVersion(new Version (8,0,10))));


        }

    }
}
