using CONTRAVI.core.Entities;
using MediatR;

namespace CONTRAVI.Application.Commands.AdminCommands.CreateAdmin
{
    public class CreateAdminCommand : IRequest<string>
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
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
