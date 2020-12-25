using Microsoft.AspNetCore.Mvc;

namespace ORDERFOOD.Web.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
