using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CONTRAVI.API.Controllers
{
    [Route("api/Trip")]
    [ApiController]
    public class TripController : ControllerBase
    {
        [HttpPost("CreateTrip")]
        public async Task<IActionResult> CreateTrip()
        {
            return Ok();
        }
        [HttpPut("UpdateTrip")]
        public async Task<IActionResult> UpdateTrip()
        {
            return Ok();
        }
        [HttpPut("IncludePassenger")]
        public async Task<IActionResult> AddPassenger()
        {
            return Ok();
        }
        [HttpDelete("RemovePassenger")]
        public async Task<IActionResult> RemovePassenger()
        {
            return Ok();
        }
        [HttpGet("GetTripByVehicle")]
        public async Task<IActionResult> GetTripByVehicle()
        {
            return Ok();
        }
        [HttpGet("GetTripByRoadMap")]
        public async Task<IActionResult> GetTripByRoadMap()
        {
            return Ok();
        }
        [HttpGet("GetTripByID")]
        public async Task<IActionResult> GetTripByID()
        {
            return Ok();
        }
        [HttpGet("GetTripByDate")]
        public async Task<IActionResult> GetTripByDate()
        {
            return Ok();
        }

    }
}
