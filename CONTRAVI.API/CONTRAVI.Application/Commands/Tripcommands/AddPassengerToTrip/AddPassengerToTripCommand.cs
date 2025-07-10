using MediatR;

namespace CONTRAVI.Application.Commands.Tripcommands.AddPassengerToTrip
{
    public class AddPassengerToTripCommand : IRequest<bool>
    {
        public int TripId { get; set; }
        public int PassengerId { get; set; }
        public string Procedure { get; set; }
        public string Destination { get; set; }
        public DateTime ScheduledTime { get; set; }
    }
}
