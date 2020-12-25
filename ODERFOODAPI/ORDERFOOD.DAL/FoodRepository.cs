using Dapper;
using ORDERFOOD.DAL.Interface;
using ORDERFOOD.Domian.Request.Food;
using ORDERFOOD.Domian.Response.Food;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ORDERFOOD.DAL
{
    public class FoodRepository : BaseRepository, IFoodRepository
    {
        public async Task<CreateFoodResult> CreateFood(CreateFoodRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ShortContent", request.ShortContent);
                parameters.Add("@Description", request.Description);
                parameters.Add("@Address ", request.Address);
                parameters.Add("@Image ", request.Image);
                parameters.Add("@Price", request.Price);
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateFoodResult>(cnn: connect,
                                                    sql: "sp_CreateFood",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DeleteFoodResult> DeleteFood(DeleteFoodRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@FoodId", request.FoodId);
               
                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteFoodResult>(cnn: connect,
                                                    sql: "sp_DeleteFood",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Food>> Gets()
        {
            return await SqlMapper.QueryAsync<Food>(cnn: connect,
                                                            sql: "sp_GetFood",
                                                            commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateFoodResult> UpdateFood(UpdateFoodRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@FoodId", request.FoodId);
                parameters.Add("@ShortContent", request.ShortContent);
                parameters.Add("@Description", request.Description);
                parameters.Add("@Address ", request.Address);
                parameters.Add("@Image ", request.Image);
                parameters.Add("@Price", request.Price);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateFoodResult>(cnn: connect,
                                                    sql: "sp_UpdateFood",
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
