using DataAccess.Helper;
using DataAccess.Models;
using DataAccess.Services;

namespace AssetManagment.Services
{
    public class AssetServices : IAssetServices
    {
        private readonly IDataAccessServices _dataAccess;

        public AssetServices(IDataAccessServices dataAccessServices)
        {
            this._dataAccess = dataAccessServices;
        }

        public Task<IEnumerable<AssetModel>> GetAssetAsync()
        {
            try
            {
                return _dataAccess.GetData<AssetModel, object>(DataAccessConstants.spAsset_GetAll, new { });

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<AssetModel?> GetAssetAsync(int id)
        {
            var result = await _dataAccess.GetData<AssetModel, dynamic>(DataAccessConstants.spAsset_Get, new { Id = id });

            return result.FirstOrDefault();
        }

        public Task InsertAssetAsync(AssetModel asset)
        {
            return _dataAccess.SaveData(DataAccessConstants.spAsset_Insert, new { asset.AssetName, asset.AssetSerialNumber, asset.AssetType, asset.AssetOwner, asset.ApprovedBy });
        }

        public Task UpdateAssetAsync(AssetModel asset)
        {
            return _dataAccess.SaveData(DataAccessConstants.spAsset_Update, asset);
        }

        public Task DeleteAssetAsync(int id)
        {
            return _dataAccess.SaveData(DataAccessConstants.spAsset_Delete, new { id });
        }
    }
}
