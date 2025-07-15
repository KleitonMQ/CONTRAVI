using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.DriverCommands.UpdateDriver
{
    public class UpdateDriverCommandHandler : IRequestHandler<UpdateDriverCommand, string>
    {
        private readonly IDriverRepository _riverRepository;
        public UpdateDriverCommandHandler(IDriverRepository driverRepository)
        {
            _riverRepository = driverRepository;
        }
        public async Task<string> Handle(UpdateDriverCommand request, CancellationToken cancellationToken)
        {
            var address = new Address(request.UF, request.CEP, request.City, request.Neighborhood, request.Street, request.Number, request.AddressComplement);
            return await _riverRepository.UpdateDriverAsync(new Driver(request.UserName, request.PhoneNumber, request.Email, address, request.CNH, request.Password, request.Login));
        }
    }
}
