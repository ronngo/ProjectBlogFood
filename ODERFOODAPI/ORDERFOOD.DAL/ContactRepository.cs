using Dapper;
using ORDERFOOD.DAL.Interface;
using ORDERFOOD.Domian.Request.Contact;
using ORDERFOOD.Domian.Response.Contact;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ORDERFOOD.DAL
{
    public class ContactRepository : BaseRepository, IContactRepository
    {
        public async Task<CreateContactResult> CreateContact(CreateContactRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", request.Name);
                parameters.Add("@Gmail", request.Gmail);
                parameters.Add("@Evaluate ", request.Evaluate);
                parameters.Add("@Description ", request.Description);
                
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateContactResult>(cnn: connect,
                                                    sql: "sp_CreateContact",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DeleteContactResult> DeleteContact(DeleteContactRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ContactId", request.ContactId);

                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteContactResult>(cnn: connect,
                                                    sql: "sp_DeleteContact",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Contact>> Gets()
        {
            return await SqlMapper.QueryAsync<Contact>(cnn: connect,
                                                            sql: "sp_GetContact",
                                                            commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateContactResult> UpdateContact(UpdateContactRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ContactId", request.ContactId);
                parameters.Add("@Name", request.Name);
                parameters.Add("@Gmail", request.Gmail);
                parameters.Add("@Evaluate ", request.Evaluate);
                parameters.Add("@Description ", request.Description);

                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateContactResult>(cnn: connect,
                                                    sql: "sp_UpdateContact",
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
