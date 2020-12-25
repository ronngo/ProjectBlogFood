using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ORDERFOOD.Domian.Request.Contact;
using ORDERFOOD.Domian.Response.Contact;
using ORDERFOOD.Web.Models;
using ORDERFOOD.Web.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ORDERFOOD.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateContact model)
        {
            if (ModelState.IsValid)
            {
                var result = new CreateContactResult();
                result = Helper.ApiHelper<CreateContactResult>.HttpPostAsync("api/Contact/create", "POST", model);
                if (result.ContactId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }



        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(UpdateFood model)
        {
            if (ModelState.IsValid)
            {
                var result = new UpdateFoodResult();
                result = Helper.ApiHelper<UpdateFoodResult>.HttpPostAsync("api/Food/Update", "POST", model);
                if (result.FoodId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(DeleteFood model)
        {
            if (ModelState.IsValid)
            {
                var result = new DeleteFoodResult();
                result = Helper.ApiHelper<DeleteFoodResult>.HttpPostAsync("api/Food/Delete", "POST", model);
                if (result.FoodId > 0)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return View(model);
        }
    }
}
