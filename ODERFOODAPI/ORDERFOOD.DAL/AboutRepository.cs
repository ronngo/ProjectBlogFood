using Dapper;
using ORDERFOOD.DAL.Interface;
using ORDERFOOD.Domian.Request.About;
using ORDERFOOD.Domian.Response.About;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ORDERFOOD.DAL
{
    public class AboutRepository : BaseRepository, IAboutRepository
    {
        public async Task<IEnumerable<About>> Gets()
        {
            return await SqlMapper.QueryAsync<About>(cnn: connect,
                                                           sql: "sp_GetAbout",
                                                           commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateAboutResult> UpdateAbout(UpdateAboutRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AboutId", request.AboutId);
                parameters.Add("@Name", request.Name);
                parameters.Add("@Description", request.Description);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateAboutResult>(cnn: connect,
                                                    sql: "sp_UpdateAbout",
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
