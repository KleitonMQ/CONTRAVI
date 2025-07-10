using CONTRAVI.Application.Commands.Tripcommands.AddPassengerToTrip;
using CONTRAVI.Application.Commands.Tripcommands.CreatetripCommand;
using CONTRAVI.Application.Commands.Tripcommands.DeletTrip;
using CONTRAVI.Application.Commands.Tripcommands.RemovePassengerFromTrip;
using CONTRAVI.Application.Commands.Tripcommands.UpdateTrip;
using CONTRAVI.Application.Queries.GetTripById;
using CONTRAVI.Application.Queries.GetTripsByDriver;
using CONTRAVI.Application.Queries.GetTripsByPassengerCNS;
using CONTRAVI.Application.Queries.GetTripsByPassengerName;
using CONTRAVI.Application.Queries.GetTripsByRoadMap;
using CONTRAVI.Application.Queries.GetTripsByTripDate;
using CONTRAVI.Application.Queries.GetTripsByVehicle;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CONTRAVI.API.Controllers
{
    [Route("api/Trip")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TripController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrip([FromBody] CreateTripCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTripById), new { id = result }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTrip(int id, [FromBody] UpdateTripCommand command)
        {
            command.Id = id;
            var success = await _mediator.Send(command);
            if (!success) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrip(int id)
        {
            var success = await _mediator.Send(new DeleteTripCommand(id));
            if (!success) return NotFound();
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTripById(int id)
        {
            var trip = await _mediator.Send(new GetTripByIdQuery(id));
            if (trip == null) return NotFound();
            return Ok(trip);
        }

        [HttpGet("vehicle/{vehicleId}")]
        public async Task<IActionResult> GetTripsByVehicle(int vehicleId)
        {
            var trips = await _mediator.Send(new GetTripsByVehicleQuery(vehicleId));
            return Ok(trips);
        }

        [HttpGet("driver/{driverId}")]
        public async Task<IActionResult> GetTripsByDriver(int driverId)
        {
            var trips = await _mediator.Send(new GetTripsByDriverQuery(driverId));
            return Ok(trips);
        }

        [HttpGet("roadmap/{roadMapId}")]
        public async Task<IActionResult> GetTripsByRoadMap(int roadMapId)
        {
            var trips = await _mediator.Send(new GetTripsByRoadMapQuery(roadMapId));
            return Ok(trips);
        }

        [HttpGet("date/{tripDate}")]
        public async Task<IActionResult> GetTripsByTripDate(DateTime tripDate)
        {
            var trips = await _mediator.Send(new GetTripsByTripDateQuery(tripDate));
            return Ok(trips);
        }

        [HttpGet("passenger/name/{name}")]
        public async Task<IActionResult> GetTripsByPassengerName(string name)
        {
            var trips = await _mediator.Send(new GetTripsByPassengerNameQuery(name));
            return Ok(trips);
        }

        [HttpGet("passenger/cns/{cns}")]
        public async Task<IActionResult> GetTripsByPassengerCNS(string cns)
        {
            var trips = await _mediator.Send(new GetTripsByPassengerCNSQuery(cns));
            return Ok(trips);
        }

        [HttpPut("{tripId}/passenger")]
        public async Task<IActionResult> AddPassengerToTrip(int tripId, [FromBody] AddPassengerToTripCommand command)
        {
            command.TripId = tripId;
            var success = await _mediator.Send(command);
            if (!success) return BadRequest("Não foi possível adicionar o passageiro.");
            return NoContent();
        }

        [HttpDelete("{tripId}/passenger/{passengerId}")]
        public async Task<IActionResult> RemovePassengerFromTrip(int tripId, int passengerId)
        {
            var success = await _mediator.Send(new RemovePassengerFromTripCommand
            {
                TripId = tripId,
                PassengerId = passengerId
            });

            if (!success) return NotFound();
            return NoContent();
        }
    }

}
