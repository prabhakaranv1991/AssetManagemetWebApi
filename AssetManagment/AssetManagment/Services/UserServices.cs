using DataAccess.Helper;
using DataAccess.Models;
using DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagment.Services
{
    public class UserServices : IUserServices
    {
        private readonly IDataAccessServices _dataAccess;

        public UserServices(IDataAccessServices dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public Task<IEnumerable<UserModel>> GetUsersAsync()
        {
            try
            {
                return _dataAccess.GetData<UserModel, object>(DataAccessConstants.spUser_GetAll, new { });

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<UserModel?> GetUserAsync(int id)
        {
            var result = await _dataAccess.GetData<UserModel, dynamic>(DataAccessConstants.spUser_Get, new { Id = id });

            return result.FirstOrDefault();
        }

        public Task InsertUserAsync(UserModel user)
        {
            return _dataAccess.SaveData(DataAccessConstants.spUser_Insert, new { user.FirstName, user.LastName, user.Phone, user.Address, user.Email });
        }

        public Task UpdateUserAsync(UserModel user)
        {
            return _dataAccess.SaveData(DataAccessConstants.spUser_Update, user);
        }

        public Task DeleteUserAsync(int id)
        {
            return _dataAccess.SaveData(DataAccessConstants.spUser_Delete, new { id });
        }
    }
}
