using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    public class Passenger : User
    {
        public Passenger() { }
        public string CNS { get; private set; }
    }
}
