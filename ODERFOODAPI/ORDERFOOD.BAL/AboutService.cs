using ORDERFOOD.BAL.Interface;
using ORDERFOOD.DAL.Interface;
using ORDERFOOD.Domian.Request.About;
using ORDERFOOD.Domian.Response.About;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.BAL
{
        public class AboutService : IAboutService
    {
        private readonly IAboutRepository aboutRepository;
        public AboutService(IAboutRepository aboutRepository)
        {
            this.aboutRepository = aboutRepository;
        }

    
         public async Task<IEnumerable<About>> Gets()
        {
            return await aboutRepository.Gets();
        }

        public async Task<UpdateAboutResult> UpdateAbout(UpdateAboutRequest request)
        {
            return await aboutRepository.UpdateAbout(request);
        }
    }
}
