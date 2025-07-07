using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.DeletePassengerDestination
{
    public class DeletePassengerDestinationCommandHandler : IRequestHandler<DeletePassengerDestinationCommand, bool>
    {
        private readonly IPassengerDestinationRepository _repository;
        public DeletePassengerDestinationCommandHandler(IPassengerDestinationRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeletePassengerDestinationCommand request, CancellationToken cancellationToken)
        {
            return await _repository.DeletePassengerDestinationAsync(request.Id);
        }
    }
}
