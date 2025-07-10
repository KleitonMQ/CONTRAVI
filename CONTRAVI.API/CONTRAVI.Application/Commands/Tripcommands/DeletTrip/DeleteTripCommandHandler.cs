using CONTRAVI.core.Repositories;
using MediatR;


namespace CONTRAVI.Application.Commands.Tripcommands.DeletTrip
{
    public class DeleteTripCommandHandler : IRequestHandler<DeleteTripCommand, bool>
    {
        private readonly ITripRepository _tripRepository;

        public DeleteTripCommandHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<bool> Handle(DeleteTripCommand request, CancellationToken cancellationToken)
        {
            return await _tripRepository.DeleteTripAsync(request.Id);
        }
    }

}
