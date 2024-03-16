
namespace DataAccess.Services
{
    public interface IDataAccessServices
    {
        Task<IEnumerable<T>> GetData<T, U>(string spName, U param, string connctionStr = "Default");
        Task SaveData<T>(string spName, T param, string connctionStr = "Default");
    }
}