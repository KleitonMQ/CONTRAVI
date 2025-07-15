using CONTRAVI.core.Entities;
using MediatR;

namespace CONTRAVI.Application.Commands.PassengerCommands.AddPassenger
{
    public class AddPassengerCommand : IRequest<string>
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CNS { get; set; }

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
