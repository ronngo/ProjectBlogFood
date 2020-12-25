using Microsoft.AspNetCore.Mvc;
using ORDERFOOD.BAL.Interface;
using ORDERFOOD.Domian.Request.User;
using System.Threading.Tasks;

namespace ORDERFOOD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;

        }

        [HttpGet]
        [Route("/api/User/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await userService.Gets());
        }

        [HttpPost]
        [Route("/api/User/create")]
        public async Task<OkObjectResult> Create(CreateUserRequest request)
        {
            return Ok(await userService.CreateUser(request));
        }


        [HttpPost]
        [Route("/api/User/Update")]
        public async Task<OkObjectResult> Update(UpdateUserRequest request)
        {
            return Ok(await userService.UpdateUser(request));
        }

        [HttpPost]
        [Route("/api/User/Delete")]
        public async Task<OkObjectResult> Delete(DeleteUserRequest request)
        {
            return Ok(await userService.DeleteUser(request));
        }
    }
}
