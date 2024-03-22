using AssetManagment.Services;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssetManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly IAssetServices _services;

        public AssetController(IAssetServices services)
        {
            this._services = services;
        }
        [HttpGet]
        public async Task<IResult> Get()
        {
            try
            {
                return Results.Ok(await _services.GetAssetAsync());
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
                var result = await _services.GetAssetAsync(id);
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
        public async Task<IResult> Post([FromBody] AssetModel asset)
        {
            try
            {
                await _services.InsertAssetAsync(asset);
                return Results.Ok();
            }
            catch (Exception e)
            {

                return Results.Problem(e.Message);
            }
        }

        [HttpPut]
        public async Task<IResult> Put([FromBody] AssetModel asset)
        {
            try
            {
                await _services.UpdateAssetAsync(asset);
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
                await _services.DeleteAssetAsync(id);
                return Results.Ok();
            }
            catch (Exception e)
            {

                return Results.Problem(e.Message);
            }
        }
    }
}
