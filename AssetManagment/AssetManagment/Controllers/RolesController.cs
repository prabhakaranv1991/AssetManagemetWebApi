using AssetManagment.Services;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssetManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRolesServices _services;

        public RolesController(IRolesServices services)
        {
            this._services = services;
        }
        // GET: api/<RolesController>
        [HttpGet]
        public async Task<IResult> Get()
        {
            try
            {
                return Results.Ok(await _services.GetUsersAsync());
            }
            catch (Exception e)
            {

                return Results.Problem(e.Message);
            }
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            try
            {
                var result = await _services.GetUserAsync(id);
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

        // POST api/<RolesController>
        [HttpPost]
        public void Post([FromBody] RolesModel roles)
        {
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RolesModel role)
        {
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
