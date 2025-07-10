using CONTRAVI.Application.ViewModels;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripsByDriver
{
    public class GetTripsByDriverQuery : IRequest<List<TripViewModel>>
    {
        public int DriverId { get; set; }

        public GetTripsByDriverQuery(int driverId)
        {
            DriverId = driverId;
        }
    }
}