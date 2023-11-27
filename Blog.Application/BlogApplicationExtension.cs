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
            services.AddEntityFrameworkCore();
        }

    }
}
