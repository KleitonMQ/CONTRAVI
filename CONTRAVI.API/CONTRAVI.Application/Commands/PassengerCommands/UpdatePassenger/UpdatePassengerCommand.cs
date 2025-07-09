using CONTRAVI.core.Entities;
using MediatR;

namespace CONTRAVI.Application.Commands.PassengerCommands.UpdatePassenger
{
    public class UpdatePassengerCommand : IRequest<string>
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CNS { get; set; }
        public Address Address { get; set; }
    }
}
