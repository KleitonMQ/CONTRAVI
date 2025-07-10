using MediatR;


namespace CONTRAVI.Application.Commands.Tripcommands.DeletTrip
{
    public class DeleteTripCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public DeleteTripCommand(int id)
        {
            Id = id;
        }
    }
}
