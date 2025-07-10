using CONTRAVI.Application.ViewModels;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripsByRoadMap
{
    public class GetTripsByRoadMapQuery : IRequest<List<TripViewModel>>
    {
        public int RoadMapId { get; set; }

        public GetTripsByRoadMapQuery(int roadMapId)
        {
            RoadMapId = roadMapId;
        }
    }
}