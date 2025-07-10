using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.Tripcommands.CreatetripCommand
{
    public class CreateTripCommandHandler : IRequestHandler<CreateTripCommand, string>
    {
        private readonly ITripRepository _tripRepository;

        public CreateTripCommandHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<string> Handle(CreateTripCommand request, CancellationToken cancellationToken)
        {
            var trip = new Trip(
                request.DriverId,
                request.VehicleId,
                request.RoadMapId,
                request.DepartureTime,
                request.TripDate
            );

            await _tripRepository.AddTripAsync(trip);

            return trip.Id.ToString();
        }
    }

}
