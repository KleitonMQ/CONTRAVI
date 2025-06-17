using CONTRAVI.core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.Application.Commands.CreateDriver
{
    public class CreateDriverCommand : IRequest<string>
    {

        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CNH {  get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public string Login { get; set; }
    }
}
