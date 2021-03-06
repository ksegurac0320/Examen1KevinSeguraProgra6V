//KEVIN SEGURA CALVO EXAMEN 1 UTC PROGRA 6
using Dapper;
using Dapper.Mapper;
using Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class DataAccess : IDataAccess  //herencia
    {
        private readonly IConfiguration config;

        public DataAccess(IConfiguration _config)
        {
            config = _config;
        }

        //Conexin
        public SqlConnection DbConnection => new SqlConnection(
            new SqlConnectionStringBuilder(config.GetConnectionString("Conn")).ConnectionString
            );

        //Metodos Dapper

        public async Task<IEnumerable<T>> QueryAsync<T>(string sp, object Param = null, int? Timeout = null)//Para el listar
        {
            try
            {
                using (var exec = DbConnection)
                {
                    await exec.OpenAsync();
                    var result = exec.QueryAsync<T>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);
                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<IEnumerable<dynamic>> QueryAsync(string sp, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    await exec.OpenAsync();
                    var result = exec.QueryAsync(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);
                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<IEnumerable<T>> QueryAsync<T, B>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    await exec.OpenAsync();
                    var result = exec.QueryAsync<T, B>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);
                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<IEnumerable<T>> QueryAsync<T, B, C>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    await exec.OpenAsync();
                    var result = exec.QueryAsync<T, B, C>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);
                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<T>> QueryAsync<T, B, C, D>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    await exec.OpenAsync();
                    var result = exec.QueryAsync<T, B, C, D>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);
                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<T>> QueryAsync<T, B, C, D, E>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    await exec.OpenAsync();
                    var result = exec.QueryAsync<T, B, C, D, E>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);
                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<T>> QueryAsync<T, B, C, D, E, F>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    await exec.OpenAsync();
                    var result = exec.QueryAsync<T, B, C, D, E, F>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);
                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<T>> QueryAsync<T, B, C, D, E, F, G>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    await exec.OpenAsync();
                    var result = exec.QueryAsync<T, B, C, D, E, F, G>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);
                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        //metodo para traer el primer resultado segun la condicio que se le de
        public async Task<T> QueryFirstAsync<T>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    await exec.OpenAsync();
                    var result = exec.QueryFirstOrDefaultAsync<T>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);
                    return await result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //metodo para ejecutar
        public async Task<DBEntity> ExecuteAsync(string sp, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    await exec.OpenAsync();
                    var result = await exec.ExecuteReaderAsync(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);
                    await result.ReadAsync();

                    //devolver a la clase DBEntity
                    return new()
                    {
                        CodError = result.GetInt32(0),
                        MsgError = result.GetString(1)
                    };

                }
            }
            catch (Exception)
            {

                throw;
            }

        }




    }

    //***
}
