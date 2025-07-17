using MediatR;

namespace CONTRAVI.Application.Commands.RoadMapCommands.DeleteRoadMap
{
    public class DeleteRoadMapCommand : IRequest<Unit>
    {
        public DeleteRoadMapCommand(int id) { Id = id; }

        public int Id { get; set; }
    }
}
