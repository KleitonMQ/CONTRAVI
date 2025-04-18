using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CONTRAVI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostPassenger()
        {
            //Incluir metodo
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostAdmin()
        {
            //Incluir metodo
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> PostDriver()
        {
            //Incluir metodo
            return Ok();
        }


    }
}
