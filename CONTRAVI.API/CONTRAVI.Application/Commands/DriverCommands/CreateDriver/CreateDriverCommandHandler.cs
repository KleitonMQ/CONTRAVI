using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.DriverCommands.CreateDriver
{
    public class CreateDriverCommandHandler : IRequestHandler<CreateDriverCommand, string>
    {
        private readonly IDriverRepository _driverRepository;

        public CreateDriverCommandHandler(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }
        public async Task<string> Handle(CreateDriverCommand request, CancellationToken cancellationToken)
        {
            var address = new Address(request.UF, request.CEP, request.City, request.Neighborhood, request.Street, request.Number, request.AddressComplement);
            return await _driverRepository.AddDriverAsync(new Driver(request.UserName, request.PhoneNumber, request.Email, address, request.CNH, request.Password, request.Login));
        }
    }
}
