using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetRoadMapByID
{
    internal class GetRoadMapByIDQueryHandler : IRequestHandler<GetRoadMapByIDQuery, RoadMap>
    {
        private readonly IRoadMapRepository _roadMapRepository;

        public GetRoadMapByIDQueryHandler(IRoadMapRepository repository)
        {
            _roadMapRepository = repository;
        }
        public async Task<RoadMap> Handle(GetRoadMapByIDQuery request, CancellationToken cancellationToken)
        {
            return await _roadMapRepository.GetRoadMapByIDAsync(request.ID);
        }
    }
}
