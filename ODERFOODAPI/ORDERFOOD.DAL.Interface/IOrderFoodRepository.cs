using ORDERFOOD.Domian.Request.OrderFood;
using ORDERFOOD.Domian.Response.OrderFood;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.DAL.Interface
{
    public interface IOrderFoodRepository
    {
        Task<IEnumerable<OrderFood>> Gets();
        Task<CreateOrderFoodResult> CreateOrderFood(CreateOrderFoodRequest request);
        Task<UpdateOrderFoodResult> UpdateOrderFood(UpdateOrderFoodRequest request);

        Task<DeleteOrderFoodResult> DeleteOrderFood(DeleteOrderFoodRequest request);
    }
}
