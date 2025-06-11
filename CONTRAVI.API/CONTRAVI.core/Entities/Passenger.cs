namespace CONTRAVI.core.Entities
{
    public class Passenger : User
    {
        public Passenger(string userName, string phoneNumber, string email, Address adress, string cns) : base(userName, phoneNumber, email, adress)
        {
            CNS = cns;
        }

        public string CNS { get; private set; }
        public void Update(string userName, string phoneNumber, string email, string cNS, Address adress)
        {
            UserName = userName;
            PhoneNumber = phoneNumber;
            Email = email;
            CNS = cNS;
            Adress = adress;
        }

    }

}
