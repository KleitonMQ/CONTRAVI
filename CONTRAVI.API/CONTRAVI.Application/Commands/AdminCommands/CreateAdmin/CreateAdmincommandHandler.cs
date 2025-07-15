using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.AdminCommands.CreateAdmin
{
    public class CreateAdmincommandHandler : IRequestHandler<CreateAdminCommand, string>
    {
        private readonly IAdminRepository _adminRepository;
        public CreateAdmincommandHandler(IAdminRepository repository)
        {
            _adminRepository = repository;
        }
        public async Task<string> Handle(CreateAdminCommand request, CancellationToken cancellationToken)
        {
            var address = new Address(request.UF, request.CEP, request.City, request.Neighborhood, request.Street, request.Number, request.AddressComplement);
            var admin = new Admin(request.UserName, request.PhoneNumber, request.email, address, request.Password, request.Login);

            return await _adminRepository.AddAdminAsync(admin);
        }
    }
}
