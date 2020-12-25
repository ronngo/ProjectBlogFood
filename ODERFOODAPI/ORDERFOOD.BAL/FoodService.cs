using ORDERFOOD.BAL.Interface;
using ORDERFOOD.DAL.Interface;
using ORDERFOOD.Domian.Request.Food;
using ORDERFOOD.Domian.Response.Food;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.BAL
{

    public class FoodService : IFoodService
    {
        private readonly IFoodRepository orderRepository;
        public FoodService(IFoodRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public async Task<CreateFoodResult> CreateFood(CreateFoodRequest request)
        {
            return await orderRepository.CreateFood(request);
        }

        public async Task<DeleteFoodResult> DeleteFood(DeleteFoodRequest request)
        {
            return await orderRepository.DeleteFood(request);
        }

        public async Task<IEnumerable<Food>> Gets()
        {
            return await orderRepository.Gets();
        }

        public async Task<UpdateFoodResult> UpdateFood(UpdateFoodRequest request)
        {
            return await orderRepository.UpdateFood(request);
        }
    }
}
