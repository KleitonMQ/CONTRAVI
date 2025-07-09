using MediatR;

namespace CONTRAVI.Application.Commands.PassengerCommands.AddPassengerDestination
{
    public class CreatePassengerDestinationCommand : IRequest<string>
    {
        public int PassengerId { get; set; }
        public string Procedure { get; set; }
        public string Destination { get; set; }
        public DateTime ScheduledTime { get; set; }
    }

}
