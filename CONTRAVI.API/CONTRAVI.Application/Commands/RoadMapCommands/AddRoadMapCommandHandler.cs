using MediatR;


namespace CONTRAVI.Application.Commands.RoadMapCommands
{
    internal class AddRoadMapCommandHandler : IRequestHandler<AddRoadMapCommand, Unit>
    {
        
        public Task<Unit> Handle(AddRoadMapCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
