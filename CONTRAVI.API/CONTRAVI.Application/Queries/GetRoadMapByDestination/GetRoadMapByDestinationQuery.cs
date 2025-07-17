using CONTRAVI.core.Entities;
using MediatR;

namespace CONTRAVI.Application.Queries.GetRoadMapByDestination
{
    public class GetRoadMapByDestinationQuery : IRequest<List<RoadMap>>
    {
        public string Destination {  get; set; }
        public GetRoadMapByDestinationQuery(string destination)
        {
            Destination = destination;
        }
    }
}
