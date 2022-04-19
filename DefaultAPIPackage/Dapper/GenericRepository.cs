using Dapper;
using DefaultAPIPackage.API.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.Dapper
{
    public class GenericRepository<TEntity> where TEntity : class
    {


        private readonly IConfiguration _configuration;
        public GenericRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        private readonly DatabaseContext _dbContext;
        public GenericRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        private IDbConnection CreateConnection()
        {
            string cn = _dbContext.Database.GetDbConnection().ConnectionString;
            return new SqlConnection(cn);
        }
        /// <summary>
        /// Return the collection of T type
        /// </summary>
        /// <typeparamname="T"></typeparam>
        /// <paramname="sql"></param>
        /// <paramname="parameters"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> CollectionsAsync<T>(string sql, object parameters = null)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    var QueryResponse = await connection.QueryAsync<T>(sql: sql, param: parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3000);

                    return QueryResponse;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Return the single row
        /// </summary>
        /// <typeparamname="T"></typeparam>
        /// <paramname="sql"></param>
        /// <paramname="parameters"></param>
        /// <returns></returns>
        protected async Task<T> SingleAsync<T>(string sql, object parameters = null)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    return await connection.QuerySingleAsync<T>(new CommandDefinition(commandText: sql, parameters: parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3000));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// Used to perform insert, update, delete
        /// </summary>
        /// <typeparamname="T"></typeparam>
        /// <paramname="sql"></param>
        /// <paramname="parameters"></param>
        /// <returns></returns>
        protected async Task<T> CommandAsync<T>(string sql, object parameters = null)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    var QueryResponse = await connection.QuerySingleAsync<T>(sql: sql, param: parameters, commandType: CommandType.StoredProcedure, commandTimeout: 3000);
                    return QueryResponse;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
