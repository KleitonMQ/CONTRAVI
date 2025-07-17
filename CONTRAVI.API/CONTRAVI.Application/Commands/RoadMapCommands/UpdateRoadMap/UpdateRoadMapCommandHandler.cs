using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.RoadMapCommands.UpdateRoadMap
{
    public class UpdateRoadMapCommandHandler : IRequestHandler<UpdateRoadMapCommand, Unit>
    {
        private readonly IRoadMapRepository _roadMapRepository;

        public UpdateRoadMapCommandHandler(IRoadMapRepository repository)
        {
            _roadMapRepository = repository;
        }
        public async Task<Unit> Handle(UpdateRoadMapCommand request, CancellationToken cancellationToken)
        {
            var newRoadMap = new RoadMap(request.Departure, request.Destination, request.Arrival);
            await _roadMapRepository.UpdateRoadMapAsync(newRoadMap, request.Id);
            return Unit.Value;
        }
    }
}
