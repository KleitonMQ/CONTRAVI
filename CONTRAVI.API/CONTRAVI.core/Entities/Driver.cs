namespace CONTRAVI.core.Entities
{
    public class Driver : User
    {
        public Driver(string userName, string phoneNumber, string email, Address adress, string cnh, string password) : base(userName, phoneNumber, email, adress)
        {
            CNH = cnh;
            Password = password;
        }

        public string CNH { get; private set; }
        public string Password { get; private set; }
    }
}
