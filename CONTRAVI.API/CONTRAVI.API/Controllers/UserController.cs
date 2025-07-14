using CONTRAVI.Application.Commands.AdminCommands.CreateAdmin;
using CONTRAVI.Application.Commands.AdminCommands.LoginAdmin;
using CONTRAVI.Application.Commands.AdminCommands.UpdateAdmin;
using CONTRAVI.Application.Commands.DriverCommands.CreateDriver;
using CONTRAVI.Application.Commands.DriverCommands.LoginDriver;
using CONTRAVI.Application.Commands.PassengerCommands.AddPassenger;
using CONTRAVI.Application.Commands.PassengerCommands.UpdatePassenger;
using CONTRAVI.Application.Queries.GetAdminByName;
using CONTRAVI.Application.Queries.GetDriverByCNH;
using CONTRAVI.Application.Queries.GetDriverByName;
using CONTRAVI.Application.Queries.GetPassengerByCNS;
using CONTRAVI.Application.Queries.GetPassengerByName;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CONTRAVI.API.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpPost]
        public async Task<IActionResult> AddPassenger([FromBody]AddPassengerCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetPassengerByName), new {name = result}, result);
        }

        [HttpPut("UpdatePassenger")]
        public async Task<IActionResult> UpdatePassenger([FromBody] UpdatePassengerCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetPassengerByName), new { name = result }, result);
        }

        [HttpGet("GetPassengerByCNS")]
        public async Task<IActionResult> GetPassengerByCNS(string cns)
        {
            var passenger = await _mediator.Send(new GetPassengerByCNSQuery(cns));
            return Ok(passenger);
        }
        [HttpGet("GetPassengerByName")]
        public async Task<IActionResult> GetPassengerByName(string name)
        {
            var passengers = await _mediator.Send(new GetPassengerByNameQuery(name));
            return Ok(passengers);
        }

        [HttpPost("Admin")]
        public async Task<IActionResult> CreateAdmin([FromBody]CreateAdminCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAdminByNameQuery), new {name = result}, result);
        }

        [HttpPut("LoginAdmin")]
        public async Task<IActionResult> LoginAdmin([FromBody]LoginAdminCommand command)
        {
            var restult = await _mediator.Send(command);
            return Ok();

            //Terminar login depois de implementar token de autenticação
        }
        [HttpPut("UpdateAdmin")]
        public async Task<IActionResult> UpdateAdmin(int id, [FromBody]UpdateAdminComand command)
        {
            var result = await _mediator.Send(command);
            
            return CreatedAtAction(nameof(GetAdminByNameQuery), new {name = result}, result);
        }

        [HttpPut("GetAdminByName")]
        public async Task<IActionResult> GetAdminByName(string name)
        {
            var admins = await _mediator.Send(new GetAdminByNameQuery(name));
            return Ok(admins);
        }

        [HttpPost("Driver")]
        public async Task<IActionResult> CreateDriver([FromBody]CreateDriverCommand command)
        {
            var restul = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetDriverByNameQuery), new { name = restul }, restul);
        }

        [HttpPut("UpdateDriver")]
        public async Task<IActionResult> UpdateDriver(int id,[FromBody]UpdateAdminComand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpGet("GetDriverByCNH")]
        public async Task<IActionResult> GetDriverByCNH(string cnh)
        {
            var driver = await _mediator.Send(new GetDriverByCNHQuery(cnh));
            return Ok(driver);
        }
        [HttpGet("GetDriverByName")]
        public async Task<IActionResult> GetDriverByName(string name)
        {
            var drivers = await _mediator.Send(new GetDriverByNameQuery(name));
            return Ok(drivers);
        }
        [HttpPut("LoginDriver")]
        public async Task<IActionResult> LoginDriver([FromBody]LoginDriverCommand command)
        {
            var result = _mediator.Send(command);
            return Ok();

            //terminar metodo depois de implementar tokens autenticação
        }
    }
}
