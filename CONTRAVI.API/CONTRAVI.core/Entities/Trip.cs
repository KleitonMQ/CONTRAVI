using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    public class Trip : BaseEntity
    {
        public Trip(int driverId, Driver driver, int vehicleId, Vehicle vehicle, int roadMapId, RoadMap roadMap, DateTime departureTime, DateTime tripDate) 
        {
            DriverId = driverId;
            Driver = driver;
            VehicleId = vehicleId;
            RoadMapId = roadMapId;
            TripDate = tripDate;
            PassengerDestination = new List<PassengerDestination>();
        }
        public int DriverId { get; set; }
        public Driver Driver { get; private set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; private set; }

        public int RoadMapId { get; set; }
        public RoadMap RoadMap { get; private set; }
        public List<PassengerDestination> PassengerDestination { get; private set; }
        public DateTime DepartureTime { get; private set; }
        public DateTime TripDate { get; private set; }

    }
}
