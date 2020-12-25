using Microsoft.AspNetCore.Mvc;
using ORDERFOOD.BAL.Interface;
using ORDERFOOD.Domian.Request.About;
using System.Threading.Tasks;

namespace ORDERFOOD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService aboutService;

        public AboutController(IAboutService aboutService)
        {
            this.aboutService = aboutService;

        }


        [HttpGet]
        [Route("/api/About/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await aboutService.Gets());
        }

        [HttpPost]
        [Route("/api/About/Update")]
        public async Task<OkObjectResult> Update(UpdateAboutRequest request)
        {
            return Ok(await aboutService.UpdateAbout(request));
        }

    }
}
