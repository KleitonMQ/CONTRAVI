using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripsByTripDate
{
    public class GetTripsByTripDateQueryHandler : IRequestHandler<GetTripsByTripDateQuery, List<TripViewModel>>
    {
        private readonly ITripRepository _tripRepository;

        public GetTripsByTripDateQueryHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<List<TripViewModel>> Handle(GetTripsByTripDateQuery request, CancellationToken cancellationToken)
        {
            var trips = await _tripRepository.GetTripsByTripDateAsync(request.TripDate);

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