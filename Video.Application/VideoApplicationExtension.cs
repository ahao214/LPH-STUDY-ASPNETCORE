using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Video.Application.Contract.UserInfos;

namespace Video.Application
{
    public static class VideoApplicationExtension
    {

        public static void AddVideoApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(VideoApplicationExtension).Assembly);

            services .AddTransient <IUserInfoService,IUserInfoService>();

        }

    }
}
