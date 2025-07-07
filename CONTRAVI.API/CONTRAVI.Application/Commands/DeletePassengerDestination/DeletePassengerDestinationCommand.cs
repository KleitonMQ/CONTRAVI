using MediatR;


namespace CONTRAVI.Application.Commands.DeletePassengerDestination
{
    public class DeletePassengerDestinationCommand : IRequest<bool>
    {
        public int Id { get; private set; }
        public DeletePassengerDestinationCommand(int id) => Id = id;
    }
}
