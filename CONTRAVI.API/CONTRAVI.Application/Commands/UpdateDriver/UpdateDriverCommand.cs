﻿using CONTRAVI.core.Entities;
using MediatR;

namespace CONTRAVI.Application.Commands.UpdateDriver
{
    public class UpdateDriverCommand : IRequest<string>
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CNH { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public string Login {  get; set; }
    }
}
