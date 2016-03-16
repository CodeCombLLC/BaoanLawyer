using Microsoft.AspNet.Mvc;
using BaoanLawyer.Models;

namespace BaoanLawyer.Controllers
{
    public class BaseController : BaseController<LawyerContext, User, string>
    {
    }
}
