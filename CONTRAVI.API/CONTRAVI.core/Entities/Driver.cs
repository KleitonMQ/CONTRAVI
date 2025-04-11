using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    public class Driver : User
    {
        public Driver() { }
        public string CNH { get; private set; }
    }
}
