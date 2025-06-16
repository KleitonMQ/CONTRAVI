using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.CreateAdmin
{
    public class CreateAdmincomandHandler : IRequestHandler<CreateAdminComand, string>
    {
        private readonly IAdminRepository _adminRepository;
        public CreateAdmincomandHandler(IAdminRepository repository)
        {
            _adminRepository = repository;
        }
        public async Task<string> Handle(CreateAdminComand request, CancellationToken cancellationToken)
        {
            var admin = new Admin(request.UserName, request.PhoneNumber, request.email, request.Address, request.Password, request.Login);

            return await _adminRepository.AddAdminAsync(admin);
        }
    }
}
