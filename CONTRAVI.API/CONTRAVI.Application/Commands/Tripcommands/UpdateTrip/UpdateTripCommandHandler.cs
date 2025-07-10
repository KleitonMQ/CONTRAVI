using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.Tripcommands.UpdateTrip
{
    public class UpdateTripCommandHandler : IRequestHandler<UpdateTripCommand, bool>
    {
        private readonly ITripRepository _tripRepository;

        public UpdateTripCommandHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<bool> Handle(UpdateTripCommand request, CancellationToken cancellationToken)
        {
            var trip = new Trip(
                request.DriverId,
                request.VehicleId,
                request.RoadMapId,
                request.DepartureTime,
                request.TripDate
            );

            typeof(Trip).GetProperty("Id")?.SetValue(trip, request.Id); // Garantindo que o ID seja mantido

            await _tripRepository.UpdateTripAsync(trip);

            return true;
        }
    }

}
