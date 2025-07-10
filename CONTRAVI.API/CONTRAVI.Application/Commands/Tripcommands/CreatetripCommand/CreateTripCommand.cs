using MediatR;


namespace CONTRAVI.Application.Commands.Tripcommands.CreatetripCommand
{
    public class CreateTripCommand : IRequest<string>
    {
        public int DriverId { get; set; }
        public int VehicleId { get; set; }
        public int RoadMapId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime TripDate { get; set; }
    }

}
