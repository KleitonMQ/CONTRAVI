using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.PassengerCommands.UpdatePassenger
{
    internal class UpdatePassengerCommandHandler : IRequestHandler<UpdatePassengerCommand, string>
    {
        private readonly IPassengerRepository _passengerRepository;

        public UpdatePassengerCommandHandler(IPassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }
        public async Task<string> Handle(UpdatePassengerCommand request, CancellationToken cancellationToken)
        {
            var passenger = new Passenger(request.UserName, request.PhoneNumber, request.Email, request.Address, request.CNS);

            return await _passengerRepository.UpdatePassengerAsync(passenger);
        }
    }
}
