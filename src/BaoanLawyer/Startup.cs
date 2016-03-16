using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BaoanLawyer.Models;

namespace BaoanLawyer
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFramework()
                .AddDbContext<LawyerContext>(x =>x.UseSqlite("Data source=baoan.db"))
                .AddSqlite();

            services.AddIdentity<User, IdentityRole>(x =>
            {
                x.Password.RequireDigit = false;
                x.Password.RequiredLength = 0;
                x.Password.RequireLowercase = false;
                x.Password.RequireNonLetterOrDigit = false;
                x.Password.RequireUppercase = false;
                x.User.AllowedUserNameCharacters = null;
            })
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<LawyerContext>();

            services.AddJsonLocalization()
                 .AddCookieCulture();

            services.AddMvc();
            services.AddSmartUser<User, string>();
            services.AddSmartCookies();
            services.AddFileUpload();
            services.AddSmtpEmailSender("smtp.ym.163.com", 25, "vNext China", "noreply@vnextcn.org", "noreply@vnextcn.org", "123456");
        }

        public async void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.MinimumLevel = LogLevel.Warning;
            loggerFactory.AddConsole();

            app.UseIISPlatformHandler();
            app.UseStaticFiles();
            app.UseIdentity();
            app.UseAutoAjax();
            app.UseFileUpload();
            app.UseMvcWithDefaultRoute();

            await SampleData.InitDB(app.ApplicationServices);
        }

        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
