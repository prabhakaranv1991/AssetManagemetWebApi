using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace DataAccess.Services;

public class DataAccessServices : IDataAccessServices
{
    private readonly IConfiguration _configuration;

    public DataAccessServices(IConfiguration configuration)
    {
        this._configuration = configuration;
    }

    /// <summary>
    /// Get the Data from the Table
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    /// <param name="spName">StoredProcedure Name</param>
    /// <param name="param">where clause parameters to storedprocedure</param>
    /// <param name="connctionStr">Connection string</param>
    /// <returns></returns>
    public async Task<IEnumerable<T>> GetData<T, U>(string spName, U param, string connctionStr = "Default")
    {
        try
        {
            using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connctionStr));


            return await connection.QueryAsync<T>(spName, param, commandType: CommandType.StoredProcedure);
        }
        catch (SqlException ex)
        {
            throw;
        }
        catch (Exception e)
        {
            throw;
        }
    }

    /// <summary>
    /// To perform Insert, Update, Delete operation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="spName"></param>
    /// <param name="param"></param>
    /// <param name="connctionStr"></param>
    /// <returns></returns>
    public async Task SaveData<T>(string spName, T param, string connctionStr = "Default")
    {
        try
        {
            using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connctionStr));

            await connection.ExecuteAsync(spName, param, commandType: CommandType.StoredProcedure);

        }
        catch (SqlException ex)
        {
            throw;
        }
        catch (Exception e)
        {
            throw;
        }
    }
}
