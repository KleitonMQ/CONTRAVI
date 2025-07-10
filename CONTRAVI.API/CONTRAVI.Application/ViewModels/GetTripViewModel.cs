

namespace CONTRAVI.Application.ViewModels
{
    public class TripViewModel
    {
        public int Id { get; set; }
        public string DriverName { get; set; }
        public string VehicleModel { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime TripDate { get; set; }

        public TripViewModel(int id, string driverName, string vehicleModel, string destination, DateTime departureTime, DateTime tripDate)
        {
            Id = id;
            DriverName = driverName;
            VehicleModel = vehicleModel;
            Destination = destination;
            DepartureTime = departureTime;
            TripDate = tripDate;
        }
    }

}
