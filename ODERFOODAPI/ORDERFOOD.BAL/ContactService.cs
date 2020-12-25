using ORDERFOOD.BAL.Interface;
using ORDERFOOD.DAL.Interface;
using ORDERFOOD.Domian.Request.Contact;
using ORDERFOOD.Domian.Response.Contact;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.BAL
{

    public class ContactService : IContactService
    {
        private readonly IContactRepository contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public async Task<CreateContactResult> CreateContact(CreateContactRequest request)
        {
            return await contactRepository.CreateContact(request);
        }

        public async Task<DeleteContactResult> DeleteContact(DeleteContactRequest request)
        {
            return await contactRepository.DeleteContact(request);
        }
    

        public async Task<IEnumerable<Contact>> Gets()
        {
            return await contactRepository.Gets();
        }

        public async Task<UpdateContactResult> UpdateContact(UpdateContactRequest request)
        {
            return await contactRepository.UpdateContact(request);
        }
    }
    }

