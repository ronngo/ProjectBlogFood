using ORDERFOOD.BAL.Interface;
using ORDERFOOD.DAL.Interface;
using ORDERFOOD.Domian.Request.OrderFood;
using ORDERFOOD.Domian.Response.OrderFood;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.BAL
{

    public class OrderFoodService : IOrderFoodService
    {
        private readonly IOrderFoodRepository orderFoodRepository;
        public OrderFoodService(IOrderFoodRepository orderFoodRepository)
        {
            this.orderFoodRepository = orderFoodRepository;
        }

        public async Task<CreateOrderFoodResult> CreateOrderFood(CreateOrderFoodRequest request)
        {
            return await orderFoodRepository.CreateOrderFood(request);
        }

        public async Task<DeleteOrderFoodResult> DeleteOrderFood(DeleteOrderFoodRequest request)
        {
            return await orderFoodRepository.DeleteOrderFood(request);
        }

        public async Task<IEnumerable<OrderFood>> Gets()
        {
            return await orderFoodRepository.Gets();
        }

        public async Task<UpdateOrderFoodResult> UpdateOrderFood(UpdateOrderFoodRequest request)
        {
            return await orderFoodRepository.UpdateOrderFood(request);
        }
    }
}
