using Microsoft.AspNetCore.Mvc;

namespace ORDERFOOD.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
