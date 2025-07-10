using CONTRAVI.core.Repositories;
using MediatR;


namespace CONTRAVI.Application.Commands.Tripcommands.RemovePassengerFromTrip
{
    public class RemovePassengerFromTripCommandHandler : IRequestHandler<RemovePassengerFromTripCommand, bool>
    {
        private readonly ITripRepository _tripRepository;

        public RemovePassengerFromTripCommandHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<bool> Handle(RemovePassengerFromTripCommand request, CancellationToken cancellationToken)
        {
            var trip = await _tripRepository.GetTripByIdAsync(request.TripId);
            if (trip == null) return false;

            trip.RemovePassenger(request.PassengerId);

            await _tripRepository.UpdateTripAsync(trip);
            return true;
        }
    }
}
