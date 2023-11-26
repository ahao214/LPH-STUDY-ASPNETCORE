using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Simple.EntityFramworkCore.Sql
{
    public static class SimpleEntityFramworkCoreSqlExtension
    {

        public static IServiceCollection AddMySqlEntityFrameworkCore<IDbContext>(this IServiceCollection services, string connect)
            where IDbContext:MasterDbContext<IDbContext>
        {
            var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
            
            services.AddEntityFrameworkCore<IDbContext>(x =>
            {
                x.UseMySql(configuration.GetConnectionString(connect), new MySqlServerVersion(new Version()));
            });
            return services;


        }

    }
}
