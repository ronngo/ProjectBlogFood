using ORDERFOOD.Domian.Request.About;
using ORDERFOOD.Domian.Response.About;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.BAL.Interface
{
    public interface IAboutService
    {
        Task<IEnumerable<About>> Gets();

        Task<UpdateAboutResult> UpdateAbout(UpdateAboutRequest request);
    }
}
