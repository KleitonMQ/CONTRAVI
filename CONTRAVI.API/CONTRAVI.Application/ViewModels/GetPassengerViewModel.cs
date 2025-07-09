using CONTRAVI.core.Entities;

namespace CONTRAVI.Application.ViewModels
{
    public class GetPassengerViewModel
    {
        public GetPassengerViewModel(string userName, string phoneNumber, string email, string cNS, Address address) 
        {
            UserName = userName;
            PhoneNumber = phoneNumber;
            Email = email;
            CNS = cNS;
            Address = address;
        }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CNS { get; set; }
        public Address Address { get; set; }
    }
}
