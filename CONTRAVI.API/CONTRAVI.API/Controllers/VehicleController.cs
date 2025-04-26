using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CONTRAVI.API.Controllers
{
    [Route("api/Vehicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        [HttpPost("InsertVehicle")]
        public async Task<IActionResult> AddVehicle()
        {
            return Ok();
        }
        [HttpPut("Updatevehicle")]
        public async Task<IActionResult> UpdateVehicle()
        {
            return Ok();
        }
        [HttpGet("GetVehicleByID")]
        public async Task<IActionResult> GetById()
        {
            return Ok();
        }
    }
}
