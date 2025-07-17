using MediatR;


namespace CONTRAVI.Application.Commands.RoadMapCommands.AddRoadMap
{
    public class AddRoadMapCommand : IRequest<Unit>
    {
        public AddRoadMapCommand(string departure, string destination, string arrival)
        {
            Departure = departure;
            Destination = destination;
            Arrival = arrival;
        }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string Arrival { get; set; }
    }
}
