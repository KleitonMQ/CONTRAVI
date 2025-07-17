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
        public int DriverId { get; private set; }
        public Driver Driver { get; private set; }

        public int VehicleId { get; private set; }
        public Vehicle Vehicle { get; private set; }

        public int RoadMapId { get; private set; }
        public RoadMap RoadMap { get; private set; }
        public List<PassengerDestination> PassengerDestination { get; private set; }
        public DateTime DepartureTime { get; private set; }
        public DateTime TripDate { get; private set; }

        public void UpdateTrip(int driverId, int vehicleId, int roadMapId, DateTime departureTime, DateTime tripDate)
        {
            DriverId = driverId;
            VehicleId = vehicleId;
            RoadMapId = roadMapId;
            DepartureTime = departureTime;
            TripDate = tripDate;
        }

        public void AddPassenger(PassengerDestination destino)
        {
            if (PassengerDestination == null)
                PassengerDestination = new List<PassengerDestination>();

            if (PassengerDestination.Any(pd => pd.PassengerId == destino.PassengerId))
                throw new InvalidOperationException("Este passageiro já está na viagem.");

            PassengerDestination.Add(destino);
        }

        public void RemovePassenger(int passengerId)
        {
            var destino = PassengerDestination.FirstOrDefault(pd => pd.PassengerId == passengerId);
            if (destino == null)
                throw new InvalidOperationException("Passageiro não encontrado na viagem.");

            PassengerDestination.Remove(destino);
        }
    }
}
