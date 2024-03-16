using DataAccess.Models;

namespace AssetManagment.Services
{
    public interface IRolesServices
    {
        Task DeleteUserAsync(int id);
        Task<RolesModel?> GetUserAsync(int id);
        Task<IEnumerable<RolesModel>> GetUsersAsync();
        Task InsertUserAsync(RolesModel role);
        Task UpdateUserAsync(RolesModel role);
    }
}