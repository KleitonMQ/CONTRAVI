namespace CONTRAVI.core.Entities
{
    public class Trip : BaseEntity
    {
        public Trip(int driverId, int vehicleId, int roadMapId, DateTime departureTime, DateTime tripDate)
        {
            DriverId = driverId;
            VehicleId = vehicleId;
            RoadMapId = roadMapId;
            DepartureTime = departureTime;
            TripDate = tripDate;
            PassengerDestination = new List<PassengerDestination>();
        }

        public Trip()
        {
            
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
