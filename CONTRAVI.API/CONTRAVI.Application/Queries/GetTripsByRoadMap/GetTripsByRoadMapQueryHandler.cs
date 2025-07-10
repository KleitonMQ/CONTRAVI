using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripsByRoadMap
{
    public class GetTripsByRoadMapQueryHandler : IRequestHandler<GetTripsByRoadMapQuery, List<TripViewModel>>
    {
        private readonly ITripRepository _tripRepository;

        public GetTripsByRoadMapQueryHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<List<TripViewModel>> Handle(GetTripsByRoadMapQuery request, CancellationToken cancellationToken)
        {
            var trips = await _tripRepository.GetTripsByRoadMapAsync(request.RoadMapId);

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