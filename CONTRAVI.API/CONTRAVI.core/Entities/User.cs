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

        public string UserName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public Address Adress { get; private set; }
    }
}
