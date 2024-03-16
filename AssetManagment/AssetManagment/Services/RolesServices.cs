using DataAccess.Helper;
using DataAccess.Models;
using DataAccess.Services;

namespace AssetManagment.Services
{
    public class RolesServices : IRolesServices
    {
        private readonly IDataAccessServices _dataAccess;

        public RolesServices(IDataAccessServices dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public Task<IEnumerable<RolesModel>> GetUsersAsync()
        {
            try
            {
                return _dataAccess.GetData<RolesModel, object>(DataAccessConstants.spRole_GetAll, new { });

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<RolesModel?> GetUserAsync(int id)
        {
            var result = await _dataAccess.GetData<RolesModel, dynamic>(DataAccessConstants.spRole_Get, new { Id = id });

            return result.FirstOrDefault();
        }

        public Task InsertUserAsync(RolesModel role)
        {
            return _dataAccess.SaveData(DataAccessConstants.spRole_Insert, new { role.RoleName, role.Description });
        }

        public Task UpdateUserAsync(RolesModel role)
        {
            return _dataAccess.SaveData(DataAccessConstants.spRole_Update, role);
        }

        public Task DeleteUserAsync(int id)
        {
            return _dataAccess.SaveData(DataAccessConstants.spRole_Delete, new { id });
        }
    }
}
