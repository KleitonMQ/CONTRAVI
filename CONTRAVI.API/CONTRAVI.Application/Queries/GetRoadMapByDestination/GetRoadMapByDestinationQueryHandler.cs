using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetRoadMapByDestination
{
    internal class GetRoadMapByDestinationQueryHandler : IRequestHandler<GetRoadMapByDestinationQuery, List<RoadMap>>
    {
        private readonly IRoadMapRepository _roadMapRepository;

        public GetRoadMapByDestinationQueryHandler(IRoadMapRepository repository)
        {
            _roadMapRepository = repository;
        }

        async Task<List<RoadMap>> IRequestHandler<GetRoadMapByDestinationQuery, List<RoadMap>>.Handle(GetRoadMapByDestinationQuery request, CancellationToken cancellationToken)
        {
            var roads = await _roadMapRepository.GetRoadMapByDestinationAsync(request.Destination);
            return roads;
        }
    }
}
