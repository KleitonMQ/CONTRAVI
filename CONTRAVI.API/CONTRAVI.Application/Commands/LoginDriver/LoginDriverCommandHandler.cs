using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.Application.Commands.LoginDriver
{
    internal class LoginDriverCommandHandler : IRequestHandler<LoginDriverCommand, GetDriverByLoginViewModel>
    {
        private readonly IDriverRepository _driverRepository;
        public LoginDriverCommandHandler(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }
        public async Task<GetDriverByLoginViewModel> Handle(LoginDriverCommand request, CancellationToken cancellationToken)
        {
            var login = await _driverRepository.GetDriverByLoginAsync(request.Login, request.Password);
            if (login == null) { return null; }

            var token = "tokne"; //atualizar com authservice

            return new GetDriverByLoginViewModel(login.UserName, login.Password, token);
        }
    }
}
