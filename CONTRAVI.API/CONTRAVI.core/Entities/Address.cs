using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    public class Address : BaseEntity
    {
        public Address(string uF, string cEP, string city, string neighborhood, string street, string number, string addressComplement)
        {
            UF = uF;
            CEP = cEP;
            City = city;
            Neighborhood = neighborhood;
            Street = street;
            Number = number;
            AddressComplement = addressComplement;
        }

        public string UF { get; private set; }
        public string CEP {  get; private set; }
        public string City { get; private set; }
        public string Neighborhood { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string AddressComplement { get; private set; }        
    }
}
