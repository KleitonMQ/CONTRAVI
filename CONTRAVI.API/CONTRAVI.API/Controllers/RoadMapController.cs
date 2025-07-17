using CONTRAVI.Application.Commands.RoadMapCommands.AddRoadMap;
using CONTRAVI.Application.Commands.RoadMapCommands.DeleteRoadMap;
using CONTRAVI.Application.Commands.RoadMapCommands.UpdateRoadMap;
using CONTRAVI.Application.Queries.GetRoadMapByID;
using CONTRAVI.Application.Queries.GetRoadMapByDestination;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CONTRAVI.API.Controllers
{
    [Route("api/RoadMap")]
    [ApiController]
    public class RoadMapController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoadMapController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoadMap([FromBody] AddRoadMapCommand command)
        {
            await _mediator.Send(command);
            return Ok(); 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoadMapById(int id)
        {
            var result = await _mediator.Send(new GetRoadMapByIDQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("destination/{destination}")]
        public async Task<IActionResult> GetRoadMapByDestination(string destination)
        {
            var result = await _mediator.Send(new GetRoadMapByDestinationQuery(destination));
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoadMap(int id, [FromBody] UpdateRoadMapCommand command)
        {
            if (id != command.Id) return BadRequest("ID mismatch between route and body.");
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoadMap(int id)
        {
            await _mediator.Send(new DeleteRoadMapCommand(id));
            return NoContent();
        }
    }
}
