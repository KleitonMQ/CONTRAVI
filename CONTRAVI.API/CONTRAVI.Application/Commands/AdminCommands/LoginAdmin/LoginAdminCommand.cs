using CONTRAVI.Application.ViewModels;
using MediatR;

namespace CONTRAVI.Application.Commands.AdminCommands.LoginAdmin
{
    internal class LoginAdminCommand : IRequest<GetAdminByLoginViewModel>
    {
        public LoginAdminCommand(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; set; }
        public string Password { get; set; }

    }
}
