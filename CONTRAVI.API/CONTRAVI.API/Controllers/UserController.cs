using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CONTRAVI.API.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("Passenger")]
        public async Task<IActionResult> AddPassenger()
        {
            //Incluir metodo
            return Ok();
        }

        [HttpPut("UpdatePassenger")]
        public async Task<IActionResult> UpdatePassenger()
        {
            //incluir metodo
            return Ok();
        }

        [HttpGet("GetPassengerByCNS")]
        public async Task<IActionResult> GetPassengerByCNH()
        {
            return Ok();
        }
        [HttpGet("GetPassengerByName")]
        public async Task<IActionResult> GetPassengerByName()
        {
            return Ok();
        }

        [HttpPost("Admin")]
        public async Task<IActionResult> PostAdmin()
        {
            //Incluir metodo
            return Ok();
        }
        [HttpPost("Driver")]
        public async Task<IActionResult> PostDriver()
        {
            //Incluir metodo
            return Ok();
        }

        [HttpPut("LoginAdmin")]
        public async Task<IActionResult> LoginAdmin()
        {
            //Incluir metodo
            return Ok();
        }
        [HttpPut("UpdateAdmin")]
        public async Task<IActionResult> UpdateAdmin()
        {
            //incluir metodo
            return Ok();
        }

        [HttpPut("UpdateDriver")]
        public async Task<IActionResult> UpdateDriver()
        {
            //incluir metodo
            return Ok();
        }
        [HttpGet("GetDriverByCNH")]
        public async Task<IActionResult> GetDriverByCNH()
        {
            return Ok();
        }
        [HttpGet("GetDriverByName")]
        public async Task<IActionResult> GetDriverByName()
        {
            return Ok();
        }

    }
}
