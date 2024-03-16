using AssetManagment.Services;
using DataAccess.Models;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UsersController(IUserServices userServices)
        {
            this._userServices = userServices;
        }

        [HttpGet]
        public async Task<IResult> Get()
        {
            try
            {
                return Results.Ok(await _userServices.GetUsersAsync());
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
                var result = await _userServices.GetUserAsync(id);
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
        public async Task<IResult> Post([FromBody] UserModel user)
        {
            try
            {
                await _userServices.InsertUserAsync(user);
                return Results.Ok();
            }
            catch (Exception e)
            {

                return Results.Problem(e.Message);
            }
        }

        [HttpPut]
        public async Task<IResult> Put([FromBody] UserModel user)
        {
            try
            {
                await _userServices.UpdateUserAsync(user);
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
                await _userServices.DeleteUserAsync(id);
                return Results.Ok();
            }
            catch (Exception e)
            {

                return Results.Problem(e.Message);
            }
        }
    }
}
