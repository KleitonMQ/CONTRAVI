using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    public class User : BaseEntity
    {
        public User() { }

        public string UserName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public int IdAddress { get; private set; }
        public Address Adress { get; private set; }
    }
}
