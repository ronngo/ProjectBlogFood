using ORDERFOOD.BAL.Interface;
using ORDERFOOD.DAL.Interface;
using ORDERFOOD.Domian.Request.User;
using ORDERFOOD.Domian.Response.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDERFOOD.BAL
{

     public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<CreateUserResult> CreateUser(CreateUserRequest request)
        {
            return await userRepository.CreateUser(request);
        }

        public async Task<DeleteUserResult> DeleteUser(DeleteUserRequest request)
        {
            return await userRepository.DeleteUser(request);
        }

        public async Task<IEnumerable<User>> Gets()
        {
            return await userRepository.Gets();
        }

        public async Task<UpdateUserResult> UpdateUser(UpdateUserRequest request)
        {
            return await userRepository.UpdateUser(request);
        }
    }
}
