using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace BaoanLawyer.Models
{
    public static class SampleData
    {
        public static async Task InitDB(IServiceProvider services)
        {
            var DB = services.GetRequiredService<LawyerContext>();
            var UserManager = services.GetRequiredService<UserManager<User>>();
            var RoleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            if (DB.Database.EnsureCreated())
            {
                await RoleManager.CreateAsync(new IdentityRole("管理员"));
                await RoleManager.CreateAsync(new IdentityRole("律师"));
                await RoleManager.CreateAsync(new IdentityRole("客户服务"));
                var user = new User { UserName = "admin", Name = "超级管理员" };
                await UserManager.CreateAsync(user, "123456");
                await UserManager.AddToRoleAsync(user, "管理员");

                DB.Catalogs.Add(new Catalog { Title = "业务范围" });
                DB.SaveChanges();
            }
        }
    }
}
