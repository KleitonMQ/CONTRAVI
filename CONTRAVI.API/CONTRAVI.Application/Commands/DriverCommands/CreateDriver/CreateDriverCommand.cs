using CONTRAVI.core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.Application.Commands.DriverCommands.CreateDriver
{
    public class CreateDriverCommand : IRequest<string>
    {

        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CNH { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }

        // Address embutido
        public string UF { get; set; }
        public string CEP { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string AddressComplement { get; set; }
    }
}
