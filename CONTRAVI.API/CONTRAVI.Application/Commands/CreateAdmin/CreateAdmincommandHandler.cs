using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.CreateAdmin
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
            var admin = new Admin(request.UserName, request.PhoneNumber, request.email, request.Address, request.Password, request.Login);

            return await _adminRepository.AddAdminAsync(admin);
        }
    }
}
