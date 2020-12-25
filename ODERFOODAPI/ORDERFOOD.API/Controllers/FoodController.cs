using Microsoft.AspNetCore.Mvc;
using ORDERFOOD.BAL.Interface;
using ORDERFOOD.Domian.Request.Food;
using System.Threading.Tasks;

namespace ORDERFOOD.API.Controllers
{
    
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService foodService;

        public FoodController(IFoodService foodService)
        {
            this.foodService = foodService;

        }


        [HttpGet]
        [Route("/api/Food/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await foodService.Gets());
        }

        [HttpPost]
        [Route("/api/Food/create")]
        public async Task<OkObjectResult> Create(CreateFoodRequest request)
        {
            return Ok(await foodService.CreateFood(request));
        }


        [HttpPost]
        [Route("/api/Food/Update")]
        public async Task<OkObjectResult> Update(UpdateFoodRequest request)
        {
            return Ok(await foodService.UpdateFood(request));
        }

        [HttpPost]
        [Route("/api/Food/Delete")]
        public async Task<OkObjectResult> Delete(DeleteFoodRequest request)
        {
            return Ok(await foodService.DeleteFood(request));
        }
    }
}
