using Microsoft.AspNetCore.Mvc;

namespace ORDERFOOD.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
