using DataAccess.Models;

namespace AssetManagment.Services
{
    public interface IAssetServices
    {
        Task DeleteAssetAsync(int id);
        Task<AssetModel?> GetAssetAsync(int id);
        Task<IEnumerable<AssetModel>> GetAssetAsync();
        Task InsertAssetAsync(AssetModel asset);
        Task UpdateAssetAsync(AssetModel asset);
    }
}