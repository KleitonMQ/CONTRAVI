using MediatR;


namespace CONTRAVI.Application.Commands.Tripcommands.UpdateTrip
{
    public class UpdateTripCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int VehicleId { get; set; }
        public int RoadMapId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime TripDate { get; set; }
    }

}
