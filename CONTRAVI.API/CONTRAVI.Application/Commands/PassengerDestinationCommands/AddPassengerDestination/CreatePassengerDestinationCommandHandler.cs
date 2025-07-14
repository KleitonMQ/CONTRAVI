using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;


namespace CONTRAVI.Application.Commands.PassengerDestinationCommands.AddPassengerDestination
{
    public class CreatePassengerDestinationCommandHandler : IRequestHandler<CreatePassengerDestinationCommand, string>
    {
        private readonly IPassengerDestinationRepository _repository;
        public CreatePassengerDestinationCommandHandler(IPassengerDestinationRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(CreatePassengerDestinationCommand request, CancellationToken cancellationToken)
        {
            var entity = new PassengerDestination(request.PassengerId, request.Procedure, request.Destination, request.ScheduledTime);

            await _repository.AddPassengerDestinationAsync(entity);
            return entity.Id.ToString();
        }
    }
}
