using CONTRAVI.core.Entities;
using MediatR;

namespace CONTRAVI.Application.Queries.GetRoadMapByID
{
    public class GetRoadMapByIDQuery : IRequest<RoadMap>
    {
        public int ID { get; set; }
        public GetRoadMapByIDQuery(int id)
        {
            ID = id;
        }
    }
}
