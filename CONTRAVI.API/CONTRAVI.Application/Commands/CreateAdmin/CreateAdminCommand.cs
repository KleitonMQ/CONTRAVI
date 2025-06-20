﻿using CONTRAVI.core.Entities;
using MediatR;

namespace CONTRAVI.Application.Commands.CreateAdmin
{
    public class CreateAdminCommand : IRequest<string>
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
    }
}
