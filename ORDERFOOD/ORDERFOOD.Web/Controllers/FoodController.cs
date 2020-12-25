using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ORDERFOOD.Web.Common;
using ORDERFOOD.Web.Models;
using ORDERFOOD.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ORDERFOOD.Web.Controllers
{
    public class FoodController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FoodController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            ViewBag.Message = " food";

            

            var products = _appDbContext.Foods.Include(p => p.Category).ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            ProductCreateVM productVM = new ProductCreateVM()
            {
                Food = new Food(),
                CategorySelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.Id.ToString()
                }),
                TagSelectList = _appDbContext.Tags.Select(item => new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                })
            };

            return View(productVM);
        }

        [HttpPost]
        public IActionResult Create(ProductCreateVM productCreateVM)
        {
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;

            string upload = webRootPath + CommonDefault.ImagePath;
            string fileName = Guid.NewGuid().ToString();
            string extension = Path.GetExtension(files[0].FileName);

            using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
            {
                files[0].CopyTo(fileStream);
            }

            productCreateVM.Food.Image = fileName + extension;

            foreach (var item in productCreateVM.SelectListTagIds)
            {
                productCreateVM.Food.ProductTags.Add(new ProductTag()
                {
                    TagId = item
                });
            }

            _appDbContext.Foods.Add(productCreateVM.Food);

            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var product = _appDbContext.Foods.Find(id);
            var tags = _appDbContext.Tags.ToList();
            var selectTags = product.ProductTags.Select(x => new Tag()
            {
                Id = x.Tag.Id,
                Name = x.Tag.Name
            });
            var selectList = new List<SelectListItem>();
            tags.ForEach(i => selectList.Add(new SelectListItem(i.Name, i.Id.ToString(), selectTags.Select(x => x.Id).Contains(i.Id))));
            ProductCreateVM productVM = new ProductCreateVM()
            {
                Food = _appDbContext.Foods.FirstOrDefault(item => item.Id == id),
                CategorySelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.Id.ToString()
                }),
                TagSelectList = selectList
                /* SelectListTagIds = Product..Select(sc => sc.CourseId)*/
            };

            return View(productVM);
        }

        [HttpPost]
        public IActionResult Edit(ProductCreateVM productCreateVM)
        {
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;

            var objProduct = _appDbContext.Foods.AsNoTracking().FirstOrDefault(pro => pro.Id == productCreateVM.Food.Id);

            if (files.Count > 0)
            {
                string upload = webRootPath + CommonDefault.ImagePath;
                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                productCreateVM.Food.Image = fileName + extension;
            }
            else
            {
                productCreateVM.Food.Image = objProduct.Image;
            }

            _appDbContext.Foods.Update(productCreateVM.Food);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var books = _appDbContext.Foods.Find(id);
            if (books == null) return NotFound();

            return View(books);
        }

        [HttpPost]
        public IActionResult DeleteBook(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var books = _appDbContext.Foods.Find(id);
            if (books == null) return NotFound();

            _appDbContext.Foods.Remove(books);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
