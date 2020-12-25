using Microsoft.AspNetCore.Mvc;

namespace ORDERFOOD.Web.Controllers
{
    public class SpecialtiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
