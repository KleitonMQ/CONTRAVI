using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.RoadMapCommands.DeleteRoadMap
{
    public class DeleteRoadMapCommandHandler : IRequestHandler<DeleteRoadMapCommand, Unit>
    {
        private readonly IRoadMapRepository _roadMapRepository;

        public DeleteRoadMapCommandHandler(IRoadMapRepository repository)
        {
            _roadMapRepository = repository;
        }
        public async Task<Unit> Handle(DeleteRoadMapCommand request, CancellationToken cancellationToken)
        {
            await _roadMapRepository.DeleteRoadMapAsync(request.Id);
            return Unit.Value;
        }
    }
}
