using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.PassengerCommands.AddPassenger
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
            var address = new Address(request.UF, request.CEP, request.City, request.Neighborhood, request.Street, request.Number, request.AddressComplement);
            var passenger = new Passenger(request.UserName, request.PhoneNumber, request.Email, address, request.CNS);

            return await _passengerRepository.AddPassengerAsync(passenger);
        }
    }
}
