using System;
using EBusiness.Service.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EBusiness.Service.Areas.Identity.IdentityHostingStartup))]
namespace EBusiness.Service.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EBusinessServiceContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EBusinessServiceContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<EBusinessServiceContext>();
            });
        }
    }
}