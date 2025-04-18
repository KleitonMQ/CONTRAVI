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
        public async Task<IActionResult> PostPassenger()
        {
            //Incluir metodo
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
        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser()
        {
            //incluir metodo
            return Ok();
        }
    }
}
