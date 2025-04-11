using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    public class PassengerDestination
    {
        public int PassengerId { get; set; }
        public Passenger Passenger { get; private set; }
        public string Procedure {  get; private set; }
        public string Destination { get; private set; }
        public DateTime ScheduledTime { get; private set; }
    }
}
