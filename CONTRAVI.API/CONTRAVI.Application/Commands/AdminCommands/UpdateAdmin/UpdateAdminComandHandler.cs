using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.AdminCommands.UpdateAdmin
{
    internal class UpdateAdminComandHandler : IRequestHandler<UpdateAdminComand, string>
    {
        private readonly IAdminRepository _adminRepository;
        public UpdateAdminComandHandler(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public Task<string> Handle(UpdateAdminComand request, CancellationToken cancellationToken)
        {
            var address = new Address(request.UF, request.CEP, request.City, request.Neighborhood, request.Street, request.Number, request.AddressComplement);
            var admin = new Admin(request.UserName, request.PhoneNumber, request.email, address, request.Password, request.Login);

            return _adminRepository.UpdateAdminAsync(admin);

        }
    }
}
