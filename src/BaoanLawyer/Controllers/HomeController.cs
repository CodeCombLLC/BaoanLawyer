using System;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace BaoanLawyer.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            ViewBag.Lawyers = DB.Lawyers
                .Where(x => x.IsTop)
                .OrderByDescending(x => x.PRI)
                .Take(3)
                .ToList();

            return View();
        }
    }
}
