using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripsByVehicle
{
    public class GetTripsByVehicleQueryHandler : IRequestHandler<GetTripsByVehicleQuery, List<TripViewModel>>
    {
        private readonly ITripRepository _tripRepository;

        public GetTripsByVehicleQueryHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<List<TripViewModel>> Handle(GetTripsByVehicleQuery request, CancellationToken cancellationToken)
        {
            var trips = await _tripRepository.GetTripsByVehicleAsync(request.VehicleId);

            return trips.Select(t => new TripViewModel(
                t.Id,
                t.Driver?.UserName,
                t.Vehicle?.Model,
                t.RoadMap?.Destination,
                t.DepartureTime,
                t.TripDate
            )).ToList();
        }
    }

}
