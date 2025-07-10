using CONTRAVI.Application.ViewModels;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripsByVehicle
{
    public class GetTripsByVehicleQuery : IRequest<List<TripViewModel>>
    {
        public int VehicleId { get; set; }

        public GetTripsByVehicleQuery(int vehicleId)
        {
            VehicleId = vehicleId;
        }
    }
}