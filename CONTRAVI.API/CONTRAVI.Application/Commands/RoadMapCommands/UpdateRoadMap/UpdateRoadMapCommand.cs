using MediatR;

namespace CONTRAVI.Application.Commands.RoadMapCommands.UpdateRoadMap
{
    public class UpdateRoadMapCommand : IRequest<Unit>
    {
        public UpdateRoadMapCommand(int id, string departure, string destination, string arrival)
        {
            Id = id;
            Departure = departure;
            Destination = destination;
            Arrival = arrival;
        }
        public int Id { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string Arrival { get; set; }
    }
}
