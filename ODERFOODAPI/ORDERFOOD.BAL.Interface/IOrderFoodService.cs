using ORDERFOOD.Domian.Request.OrderFood;
using ORDERFOOD.Domian.Response.OrderFood;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.BAL.Interface
{
    public interface IOrderFoodService
    {
        Task<IEnumerable<OrderFood>> Gets();

        Task<CreateOrderFoodResult> CreateOrderFood(CreateOrderFoodRequest request);
        Task<UpdateOrderFoodResult> UpdateOrderFood(UpdateOrderFoodRequest request);

        Task<DeleteOrderFoodResult> DeleteOrderFood(DeleteOrderFoodRequest request);
    }
}
