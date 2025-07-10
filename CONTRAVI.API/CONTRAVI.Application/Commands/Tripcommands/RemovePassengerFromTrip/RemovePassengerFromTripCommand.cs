using MediatR;

namespace CONTRAVI.Application.Commands.Tripcommands.RemovePassengerFromTrip
{
    public class RemovePassengerFromTripCommand : IRequest<bool>
    {
        public int TripId { get; set; }
        public int PassengerId { get; set; }
    }
}
