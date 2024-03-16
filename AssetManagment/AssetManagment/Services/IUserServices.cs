using DataAccess.Models;

namespace AssetManagment.Services
{
    public interface IUserServices
    {
        Task DeleteUserAsync(int id);
        Task<UserModel?> GetUserAsync(int id);
        Task<IEnumerable<UserModel>> GetUsersAsync();
        Task InsertUserAsync(UserModel user);
        Task UpdateUserAsync(UserModel user);
    }
}