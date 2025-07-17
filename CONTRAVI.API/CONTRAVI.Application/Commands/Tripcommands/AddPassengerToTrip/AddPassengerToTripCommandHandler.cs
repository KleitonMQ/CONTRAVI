using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.Tripcommands.AddPassengerToTrip
{
    public class AddPassengerToTripCommandHandler : IRequestHandler<AddPassengerToTripCommand, bool>
    {
        private readonly ITripRepository _tripRepository;

        public AddPassengerToTripCommandHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<bool> Handle(AddPassengerToTripCommand request, CancellationToken cancellationToken)
        {
            var trip = await _tripRepository.GetTripByIdAsync(request.TripId);
            if (trip == null) return false;

            var passengerDestination = new PassengerDestination(
                request.PassengerId,
                request.Procedure,
                request.Destination,
                request.ScheduledTime
            );

            trip.AddPassenger(passengerDestination);

            await _tripRepository.AddPassengerDestinationAsync(passengerDestination);
            return true;
        }
    }
}
