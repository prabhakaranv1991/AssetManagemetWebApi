using AssetManagment.Services;
using DataAccess.Models;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssetManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSheetController : ControllerBase
    {
        private readonly ITimeSheetServices _timeSheetServices;

        public TimeSheetController(ITimeSheetServices timeSheetServices)
        {
            this._timeSheetServices = timeSheetServices;
        }
        [HttpGet]
        public async Task<IResult> Get()
        {
            try
            {
                return Results.Ok(await _timeSheetServices.GetTimeSheetsAsync());
            }
            catch (Exception e)
            {

                return Results.Problem(e.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            try
            {
                var result = await _timeSheetServices.GetTimeSheetAsync(id);
                if (result == null)
                {
                    return Results.NotFound(id);
                }
                return Results.Ok(result);
            }
            catch (Exception e)
            {

                return Results.Problem(e.Message);
            }
        }

        [HttpPost]
        public async Task<IResult> Post([FromBody] TimeSheetModel tmeSheet)
        {
            try
            {
                await _timeSheetServices.InsertTimeSheetAsync(tmeSheet);
                return Results.Ok();
            }
            catch (Exception e)
            {

                return Results.Problem(e.Message);
            }
        }

        [HttpPut]
        public async Task<IResult> Put([FromBody] TimeSheetModel user)
        {
            try
            {
                await _timeSheetServices.UpdateTimeSheetAsync(user);
                return Results.Ok();
            }
            catch (Exception e)
            {

                return Results.Problem(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            try
            {
                await _timeSheetServices.DeleteTimeSheetAsync(id);
                return Results.Ok();
            }
            catch (Exception e)
            {

                return Results.Problem(e.Message);
            }
        }
    }
}
