using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.EntityFramworkCore
{
    public static class SimpleEntityFrameworkExtension
    {

        /// <summary>
        /// efcore核心扩展
        /// </summary>
        /// <typeparam name="IDbContext"></typeparam>
        /// <param name="services"></param>
        /// <param name="options"></param>
        /// <param name="lifetime"></param>
        /// <returns></returns>
        public static IServiceCollection AddEntityFrameworkCore<IDbContext>(this IServiceCollection services, Action<DbContextOptionsBuilder>? options = null,
            ServiceLifetime lifetime = ServiceLifetime.Singleton) where IDbContext : MasterDbContext<IDbContext>
        {
            services.AddDbContext<IDbContext>(options, lifetime);
            return services;
        }


    }
}
