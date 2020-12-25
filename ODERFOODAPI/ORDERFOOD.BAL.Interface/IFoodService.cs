using ORDERFOOD.Domian.Request.Food;
using ORDERFOOD.Domian.Response.Food;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.BAL.Interface
{
    public interface IFoodService
    {
        Task<IEnumerable<Food>> Gets();
        Task<CreateFoodResult> CreateFood(CreateFoodRequest request);

        Task<UpdateFoodResult> UpdateFood(UpdateFoodRequest request);
        Task<DeleteFoodResult> DeleteFood(DeleteFoodRequest request);
    }
}
