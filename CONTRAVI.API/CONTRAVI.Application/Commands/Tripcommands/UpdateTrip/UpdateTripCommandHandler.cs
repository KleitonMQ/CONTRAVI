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
            var trip = await _tripRepository.GetTripByIdAsync(request.Id);
            if (trip == null) return false;

            trip.UpdateTrip(
                request.DriverId,
                request.VehicleId,
                request.RoadMapId,
                request.DepartureTime,
                request.TripDate
            );

            await _tripRepository.UpdateTripAsync(trip);
            return true;
        }

    }

}
