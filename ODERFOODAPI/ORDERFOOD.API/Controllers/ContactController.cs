using Microsoft.AspNetCore.Mvc;
using ORDERFOOD.BAL.Interface;
using ORDERFOOD.Domian.Request.Contact;
using System.Threading.Tasks;

namespace ORDERFOOD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;

        }

        [HttpGet]
        [Route("/api/Contact/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await contactService.Gets());
        }

        [HttpPost]
        [Route("/api/Contact/create")]
        public async Task<OkObjectResult> Create(CreateContactRequest request)
        {
            return Ok(await contactService.CreateContact(request));
        }


        [HttpPost]
        [Route("/api/Contact/Update")]
        public async Task<OkObjectResult> Update(UpdateContactRequest request)
        {
            return Ok(await contactService.UpdateContact(request));
        }

        [HttpPost]
        [Route("/api/Contact/Delete")]
        public async Task<OkObjectResult> Delete(DeleteContactRequest request)
        {
            return Ok(await contactService.DeleteContact(request));
        }
    }
}
