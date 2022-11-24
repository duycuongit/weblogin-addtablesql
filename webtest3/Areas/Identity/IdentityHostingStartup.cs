using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using webtest3.Areas.Identity.Data;
using webtest3.Data;

[assembly: HostingStartup(typeof(webtest3.Areas.Identity.IdentityHostingStartup))]
namespace webtest3.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<webtest3DbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("webtest3DbContextConnection")));

                services.AddDefaultIdentity<webtest3User>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<webtest3DbContext>();
            });
        }
    }
}