using MediatR;


namespace CONTRAVI.Application.Commands.RoadMapCommands
{
    public class AddRoadMapCommand : IRequest<Unit>
    {
        public AddRoadMapCommand(string departure, string destination, string arrival)
        {
            Departure = departure;
            Destination = destination;
            Arrival = arrival;
        }
        public string Departure { get; private set; }
        public string Destination { get; private set; }
        public string Arrival { get; private set; }
    }
}
