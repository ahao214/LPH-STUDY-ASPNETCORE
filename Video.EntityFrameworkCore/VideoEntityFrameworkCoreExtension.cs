using Microsoft.Extensions.DependencyInjection;
using Simple.EntityFramworkCore.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video.Domains.Users;
using Video.EntityFrameworkCore.Users;

namespace Video.EntityFrameworkCore
{
    public static class VideoEntityFrameworkCoreExtension
    {
        public static IServiceCollection AddVideoEntityFrameworkCor(this IServiceCollection services)
        {
            services.AddMySqlEntityFrameworkCore<VideoDbContext>("Default");
            services.AddTransient<IUserInfoRepository, UserInfoRepository>();
            return services;
        }

    }
}
