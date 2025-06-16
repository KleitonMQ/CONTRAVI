namespace CONTRAVI.core.Entities
{
    public class User : BaseEntity
    {
        public User(string userName, string phoneNumber, string email, Address adress)
        {
            UserName = userName;
            PhoneNumber = phoneNumber;
            Email = email;
            Adress = adress;
        }
        public User()
        {
            
        }

        public string UserName { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public string Email { get; protected set; }
        public int AddressId { get; private set; }
        public Address Adress { get; protected set; }
    }
}
