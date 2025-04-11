using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    internal class Trip : BaseEntity
    {
        public Driver Driver { get; private set; }
        public Vehicle Vehicle { get; private set; }
        public RoadMap RoadMap { get; private set; }
        public List<PassengerDestination> DestinationList { get; private set; }
        public DateTime DepartureTime { get; private set; }
        public DateTime TripDate { get; private set; }
    }
}
