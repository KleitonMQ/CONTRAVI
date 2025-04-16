using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    public class RoadMap : BaseEntity
    {
        public RoadMap(string departure, string destination, string arrival) 
        { 
            Departure = departure;
            Destination = destination;
            Arrival = arrival;
        }
        public string Departure {  get; private set; }
        public string Destination { get; private set; }
        public string Arrival { get; private set; }
    }
}
