using Microsoft.AspNetCore.Mvc;

namespace ORDERFOOD.Web.Controllers
{
    public class OrderFoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
