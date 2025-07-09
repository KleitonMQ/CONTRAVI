using MediatR;

namespace CONTRAVI.Application.Commands.PassengerDestinationCommands.UpdatePassengerDestination
{
    public class UpdatePassengerDestinationCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Procedure { get; set; }
        public string Destination { get; set; }
        public DateTime ScheduledTime { get; set; }
    }
}
