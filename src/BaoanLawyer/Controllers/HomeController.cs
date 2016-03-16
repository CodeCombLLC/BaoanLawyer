using Microsoft.AspNet.Mvc;

namespace BaoanLawyer.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
