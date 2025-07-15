using CONTRAVI.Application.Commands.VehicleCommands.AddVehicle;
using CONTRAVI.Application.Commands.VehicleCommands.UpdateVehicle;
using CONTRAVI.Application.Queries.GetVehicleById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CONTRAVI.API.Controllers
{
    [Route("api/Vehicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VehicleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("InsertVehicle")]
        public async Task<IActionResult> AddVehicle([FromBody]AddVehicleCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok();
        }
        [HttpPut("Updatevehicle")]
        public async Task<IActionResult> UpdateVehicle([FromBody]UpdateVehicleCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok();
        }
        [HttpGet("GetVehicleByID")]
        public async Task<IActionResult> GetById(int id)
        {
            var vehicle = await _mediator.Send(new GetVehicleByIdQuery(id));
            return Ok(vehicle);
        }
    }
}
