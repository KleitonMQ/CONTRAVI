using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.AdminCommands.LoginAdmin
{
    public class LoginAdminCommandHandler : IRequestHandler<LoginAdminCommand, GetAdminByLoginViewModel>
    {
        private readonly IAdminRepository _adminRepository;
        public LoginAdminCommandHandler(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public async Task<GetAdminByLoginViewModel> Handle(LoginAdminCommand request, CancellationToken cancellationToken)
        {
            var login = await _adminRepository.GetAdminByLoginAndPasswordAsync(request.Login, request.Password);

            if (login == null) { return null; }

            var token = "token"; //atualizar para autenticador

            return new GetAdminByLoginViewModel(login.UserName, login.Password, token);
        }
    }
}
