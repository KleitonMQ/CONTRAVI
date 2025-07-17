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

            var destino = trip.PassengerDestination.FirstOrDefault(pd => pd.PassengerId == request.PassengerId);
            if (destino == null) return false;

            // Remove do banco diretamente
            await _tripRepository.RemovePassengerDestination(destino);

            return true;
        }
    }
}
