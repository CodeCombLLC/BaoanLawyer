using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace BaoanLawyer.Controllers
{
    public class CompanyController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Resource()
        {
            var ret = DB.Resources
                .OrderByDescending(x => x.Time);

            return PagedView(ret);
        }
    }
}
