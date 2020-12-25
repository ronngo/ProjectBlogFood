using Microsoft.AspNetCore.Mvc;
using ORDERFOOD.Web.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace ORDERFOOD.Web.Controllers
{
    public class OrderFoodController : Controller
    {
        
        public IActionResult Index()
        {
            List<OrderFood> manufactories = new List<OrderFood>();
            manufactories = Helper.ApiHelper<List<OrderFood>>.HttpGetAsync("api/OrderFood/gets");
            return View(manufactories);
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
        public IActionResult Create(CreateOrderFood model)
        {
            if (ModelState.IsValid)
            {
                var result = new CreateOrderFoodResult();
                result = Helper.ApiHelper<CreateOrderFoodResult>.HttpPostAsync("api/manufactory/create", "POST", model);
                if (result.Id > 0)
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
        public IActionResult Update(UpdateOrderFood model)
        {
            if (ModelState.IsValid)
            {
                var result = new UpdateOrderFoodResult();
                result = Helper.ApiHelper<UpdateOrderFoodResult>.HttpPostAsync("api/manufactory/Update", "POST", model);
                if (result.Id > 0)
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
        public IActionResult Delete(DeleteOrderFood model)
        {
            if (ModelState.IsValid)
            {
                var result = new DeleteOrderFoodResult();
                result = Helper.ApiHelper<DeleteOrderFoodResult>.HttpPostAsync("api/manufactory/Delete", "POST", model);
                if (result.Id > 0)
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