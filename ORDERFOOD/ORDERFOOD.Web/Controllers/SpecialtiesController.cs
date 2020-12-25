using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ORDERFOOD.Web.Models;
using ORDERFOOD.Web.ViewModels;
using System.Linq;

namespace ORDERFOOD.Web.Controllers
{
    public class SpecialtiesController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;

        public SpecialtiesController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                /*Products = _appDbContext.Products.Where(prod => EF.Functions.Like(prod.Name, "%a%")).Include(p => p.Category).ToList(),*/
                Foods = _appDbContext.Foods.Include(p => p.Category).ToList(),
                Categories = _appDbContext.Categories

            };


            return View(homeIndexVM);
        }
    }
}
