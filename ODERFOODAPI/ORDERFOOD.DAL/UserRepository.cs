using Dapper;
using ORDERFOOD.DAL.Interface;
using ORDERFOOD.Domian.Request.User;
using ORDERFOOD.Domian.Response.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ORDERFOOD.DAL
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public async Task<CreateUserResult> CreateUser(CreateUserRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", request.Name);
                parameters.Add("@Gmail", request.Gmail);
                parameters.Add("@Password ", request.Password);
                
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateUserResult>(cnn: connect,
                                                    sql: "sp_CreateUser",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DeleteUserResult> DeleteUser(DeleteUserRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserId", request.UserId);
               

                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteUserResult>(cnn: connect,
                                                    sql: "sp_DeleteUser",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<User>> Gets()
        {
            return await SqlMapper.QueryAsync<User>(cnn: connect,
                                                           sql: "sp_GetUser",
                                                           commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateUserResult> UpdateUser(UpdateUserRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserId", request.UserId);
                parameters.Add("@Name", request.Name);
                parameters.Add("@Gmail", request.Gmail);
                parameters.Add("@Password ", request.Password);

                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateUserResult>(cnn: connect,
                                                    sql: "sp_UpdateUser",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
