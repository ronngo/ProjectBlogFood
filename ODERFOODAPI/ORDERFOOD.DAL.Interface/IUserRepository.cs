using ORDERFOOD.Domian.Request.User;
using ORDERFOOD.Domian.Response.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.DAL.Interface
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> Gets();

        Task<CreateUserResult> CreateUser(CreateUserRequest request);
        Task<UpdateUserResult> UpdateUser(UpdateUserRequest request);

        Task<DeleteUserResult> DeleteUser(DeleteUserRequest request);
    }
}
