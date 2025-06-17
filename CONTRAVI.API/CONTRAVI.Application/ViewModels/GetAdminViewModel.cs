using CONTRAVI.core.Entities;


namespace CONTRAVI.Application.ViewModels
{
    public class GetAdminViewModel
    {
        public GetAdminViewModel(string userName, string phoneNumber, string email, Address address)
        {
            UserName = userName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
