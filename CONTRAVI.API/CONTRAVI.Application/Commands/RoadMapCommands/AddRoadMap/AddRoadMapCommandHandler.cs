using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;


namespace CONTRAVI.Application.Commands.RoadMapCommands.AddRoadMap
{
    public class AddRoadMapCommandHandler : IRequestHandler<AddRoadMapCommand, Unit>
    {
        private readonly IRoadMapRepository _roadMapRepository;

        public AddRoadMapCommandHandler(IRoadMapRepository roadMapRepository)
        {
            _roadMapRepository = roadMapRepository;
        }
        public async Task<Unit> Handle(AddRoadMapCommand request, CancellationToken cancellationToken)
        {
            var roadMap = new RoadMap(request.Departure, request.Destination, request.Arrival);
            await _roadMapRepository.AddRoadMapAsync(roadMap);
            return Unit.Value;
        }
    }
}
