using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.UpdatePassengerDestination
{
    public class UpdatePassengerDestinationCommandHandler : IRequestHandler<UpdatePassengerDestinationCommand, bool>
    {
        private readonly IPassengerDestinationRepository _repository;

        public UpdatePassengerDestinationCommandHandler(IPassengerDestinationRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(UpdatePassengerDestinationCommand request, CancellationToken cancellationToken)
        {
            var entity = new PassengerDestination(request.Id, request.Procedure, request.Destination, request.ScheduledTime);
            await _repository.UpdatePassengerDestinationAsync(entity);
            return true;
        }
    }
}
