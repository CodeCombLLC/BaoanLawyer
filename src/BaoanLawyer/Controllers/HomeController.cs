using System;
using System.Linq;
using System.IO;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.PlatformAbstractions;

namespace BaoanLawyer.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index([FromServices] IApplicationEnvironment env)
        {
            ViewBag.Lawyers = DB.Lawyers
                .Where(x => x.IsTop)
                .OrderByDescending(x => x.PRI)
                .Take(3)
                .ToList();

            ViewBag.Welcome = System.IO.File.ReadAllText(env.ApplicationBasePath + "/Statics/Welcome.txt");
            ViewBag.Advantages = System.IO.File.ReadAllText(env.ApplicationBasePath + "/Statics/Advantages.txt");
            ViewBag.Practice = System.IO.File.ReadAllText(env.ApplicationBasePath + "/Statics/Practice.txt");
            ViewBag.Practices = DB.Informations
                .Where(x => x.Catalog.Title == "业务范围")
                .Take(11)
                .ToList();

            return View();
        }
    }
}
