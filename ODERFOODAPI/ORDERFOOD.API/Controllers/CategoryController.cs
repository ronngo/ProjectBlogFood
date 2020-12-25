using Microsoft.AspNetCore.Mvc;
using ORDERFOOD.BAL.Interface;
using ORDERFOOD.Domian.Request.Category;
using System.Threading.Tasks;

namespace ORDERFOOD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;

        }

        [HttpGet]
        [Route("/api/Category/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await categoryService.Gets());
        }

        [HttpPost]
        [Route("/api/Category/create")]
        public async Task<OkObjectResult> Create(CreateCategoryRequest request)
        {
            return Ok(await categoryService.CreateCategory(request));
        }


        [HttpPost]
        [Route("/api/Category/Update")]
        public async Task<OkObjectResult> Update(UpdateCategoryRequest request)
        {
            return Ok(await categoryService.UpdateCategory(request));
        }

        [HttpPost]
        [Route("/api/Category/Delete")]
        public async Task<OkObjectResult> Delete(DeleteCategoryRequest request)
        {
            return Ok(await categoryService.DeleteCategory(request));
        }
    }
}
