using Microsoft.AspNetCore.Mvc;
using ORDERFOOD.BAL.Interface;
using ORDERFOOD.Domian.Request.OrderFood;
using System.Threading.Tasks;

namespace ORDERFOOD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderFoodController : ControllerBase
   
    {
        private readonly IOrderFoodService orderFoodService;

        public OrderFoodController(IOrderFoodService orderFoodService)
        {
            this.orderFoodService = orderFoodService;

        }

        [HttpGet]
        [Route("/api/OrderFood/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await orderFoodService.Gets());
        }

        [HttpPost]
        [Route("/api/OrderFood/create")]
        public async Task<OkObjectResult> Create(CreateOrderFoodRequest request)
        {
            return Ok(await orderFoodService.CreateOrderFood(request));
        }

        [HttpPost]
        [Route("/api/OrderFood/Update")]
        public async Task<OkObjectResult> Update(UpdateOrderFoodRequest request)
        {
            return Ok(await orderFoodService.UpdateOrderFood(request));
        }

        [HttpPost]
        [Route("/api/OrderFood/Delete")]
        public async Task<OkObjectResult> Delete(DeleteOrderFoodRequest request)
        {
            return Ok(await orderFoodService.DeleteOrderFood(request));
        }
    }
}
