using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.AddPassenger
{
    public class AddPassengerCommandHandler : IRequestHandler<AddPassengerCommand, string>
    {
        private readonly IPassengerRepository _passengerRepository;

        public AddPassengerCommandHandler(IPassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }
        public async Task<string> Handle(AddPassengerCommand request, CancellationToken cancellationToken)
        {
            var passenger = new Passenger(request.UserName, request.PhoneNumber, request.Email, request.Address, request.CNS);

            return await _passengerRepository.AddPassengerAsync(passenger);
        }
    }
}
