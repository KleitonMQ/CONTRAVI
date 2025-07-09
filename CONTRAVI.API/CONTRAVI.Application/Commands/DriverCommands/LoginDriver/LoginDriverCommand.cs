using CONTRAVI.Application.ViewModels;
using MediatR;

namespace CONTRAVI.Application.Commands.DriverCommands.LoginDriver
{
    public class LoginDriverCommand : IRequest<GetDriverByLoginViewModel>
    {
        public LoginDriverCommand(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
