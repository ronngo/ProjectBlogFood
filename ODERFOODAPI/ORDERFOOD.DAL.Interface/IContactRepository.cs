using ORDERFOOD.Domian.Request.Contact;
using ORDERFOOD.Domian.Response.Contact;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.DAL.Interface
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> Gets();

        Task<CreateContactResult> CreateContact(CreateContactRequest request);
        Task<UpdateContactResult> UpdateContact(UpdateContactRequest request);

        Task<DeleteContactResult> DeleteContact(DeleteContactRequest request);
    }
}
