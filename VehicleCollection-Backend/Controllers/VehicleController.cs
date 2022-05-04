using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehicleCollection_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Vehicle>>> Get()
        {
            return Ok(new List<Vehicle>());
        }

        [HttpPut]
        public async Task<ActionResult<List<Vehicle>>> Create(Vehicle v)
        {
            return Ok(new List<Vehicle>());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Vehicle>>> Delete(Vehicle V)
        {
            return Ok(new List<Vehicle>());
        }
    }
}
