using DataAccess.Models;

namespace AssetManagment.Services
{
    public interface ITimeSheetServices
    {
        Task DeleteTimeSheetAsync(int id);
        Task<IEnumerable<TimeSheetModel>> GetTimeSheetsAsync();
        Task<TimeSheetModel?> GetTimeSheetAsync(int id);
        Task InsertTimeSheetAsync(TimeSheetModel tmesheet);
        Task UpdateTimeSheetAsync(TimeSheetModel tmesheet);
    }
}