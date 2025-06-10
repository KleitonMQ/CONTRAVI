namespace CONTRAVI.core.Entities
{
    public class Admin : User
    {
        public Admin(string userName, string phoneNumber, string email, Address adress, string password, string login) : base(userName, phoneNumber, email, adress)
        {
            Password = password;
            Login = login;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }

        public String Update(string userName, string phoneNumber, string email, string login, string password, Address adress)
        {
            UserName = userName;
            PhoneNumber = phoneNumber;
            Email = email;
            Login = login;
            Password = password;
            Adress = adress;

            return this.UserName;
        }
    }
}
