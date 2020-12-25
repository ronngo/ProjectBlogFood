using Dapper;
using ORDERFOOD.DAL.Interface;
using ORDERFOOD.Domian.Request.OrderFood;
using ORDERFOOD.Domian.Response.OrderFood;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ORDERFOOD.DAL
{
    public class OrderFoodRepository : BaseRepository, IOrderFoodRepository
    {
        public async Task<CreateOrderFoodResult> CreateOrderFood(CreateOrderFoodRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@FoodName", request.FoodName);
                parameters.Add("@CustomerName", request.CustomerName);
                parameters.Add("@PhoneNumber ", request.PhoneNumber);
                parameters.Add("@Address ", request.Address);
                parameters.Add("@Price", request.Price);
                parameters.Add("@Image ", request.Image);
                parameters.Add("@Person", request.Person);

                return await SqlMapper.QueryFirstOrDefaultAsync<CreateOrderFoodResult>(cnn: connect,
                                                    sql: "sp_CreateOrderFood",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  async Task<DeleteOrderFoodResult> DeleteOrderFood(DeleteOrderFoodRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@OrderFoodId", request.OrderFoodId);

                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteOrderFoodResult>(cnn: connect,
                                                    sql: "sp_DeleteOrderFood",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<OrderFood>> Gets()
        {
            return await SqlMapper.QueryAsync<OrderFood>(cnn: connect,
                                                            sql: "sp_GetOrderFood",
                                                            commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateOrderFoodResult> UpdateOrderFood(UpdateOrderFoodRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@OrderFoodId", request.OrderFoodId);
                parameters.Add("@FoodName", request.FoodName);
                parameters.Add("@CustomerName", request.CustomerName);
                parameters.Add("@PhoneNumber ", request.PhoneNumber);
                parameters.Add("@Address ", request.Address);
                parameters.Add("@Price", request.Price);
                parameters.Add("@Image ", request.Image);
                parameters.Add("@Person", request.Person);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateOrderFoodResult>(cnn: connect,
                                                    sql: "sp_UpdateOrderFood",
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
