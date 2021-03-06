﻿using Dapper;
using ORDERFOOD.DAL.Interface;
using ORDERFOOD.Domian.Request.Category;
using ORDERFOOD.Domian.Response.Category;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ORDERFOOD.DAL
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public async Task<CreateCategoryResult> CreateCategory(CreateCategoryRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryName", request.CategoryName);
                
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateCategoryResult>(cnn: connect,
                                                    sql: "sp_CreateCategory",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DeleteCategoryResult> DeleteCategory(DeleteCategoryRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", request.CategoryId);
               

                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteCategoryResult>(cnn: connect,
                                                    sql: "sp_DeleteCategory",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Category>> Gets()
        {
            return await SqlMapper.QueryAsync<Category>(cnn: connect,
                                                            sql: "sp_GetCategory",
                                                            commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateCategoryResult> UpdateCategory(UpdateCategoryRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", request.CategoryId);
                parameters.Add("@CategoryName", request.CategoryName);

                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateCategoryResult>(cnn: connect,
                                                    sql: "sp_UpdateCategory",
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
