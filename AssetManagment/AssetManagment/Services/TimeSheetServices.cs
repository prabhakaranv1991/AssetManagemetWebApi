using DataAccess.Helper;
using DataAccess.Models;
using DataAccess.Services;

namespace AssetManagment.Services
{
    public class TimeSheetServices : ITimeSheetServices
    {
        private readonly IDataAccessServices _dataAccess;

        public TimeSheetServices(IDataAccessServices dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public Task<IEnumerable<TimeSheetModel>> GetTimeSheetsAsync()
        {
            try
            {
                return _dataAccess.GetData<TimeSheetModel, object>(DataAccessConstants.spTimeSheet_GetAll, new { });

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<TimeSheetModel?> GetTimeSheetAsync(int id)
        {
            var result = await _dataAccess.GetData<TimeSheetModel, dynamic>(DataAccessConstants.spTimeSheet_Get, new { Id = id });

            return result.FirstOrDefault();
        }

        public Task InsertTimeSheetAsync(TimeSheetModel tmesheet)
        {
            return _dataAccess.SaveData(DataAccessConstants.spTimeSheet_Insert, new { tmesheet.EmpId, tmesheet.LoginTime, tmesheet.LogoutTime });
        }

        public Task UpdateTimeSheetAsync(TimeSheetModel tmesheet)
        {
            return _dataAccess.SaveData(DataAccessConstants.spTimeSheet_Update, tmesheet);
        }

        public Task DeleteTimeSheetAsync(int id)
        {
            return _dataAccess.SaveData(DataAccessConstants.spTimeSheet_Delete, new { id });
        }
    }
}
