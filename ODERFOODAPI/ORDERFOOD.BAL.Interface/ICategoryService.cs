using ORDERFOOD.Domian.Request.Category;
using ORDERFOOD.Domian.Response.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.BAL.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> Gets();

        Task<CreateCategoryResult> CreateCategory(CreateCategoryRequest request);
        Task<UpdateCategoryResult> UpdateCategory(UpdateCategoryRequest request);

        Task<DeleteCategoryResult> DeleteCategory(DeleteCategoryRequest request);
    }
}
