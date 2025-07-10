using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;


namespace CONTRAVI.Application.Queries.GetTripsByDriver
{
    public class GetTripsByDriverQueryHandler : IRequestHandler<GetTripsByDriverQuery, List<TripViewModel>>
    {
        private readonly ITripRepository _tripRepository;

        public GetTripsByDriverQueryHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<List<TripViewModel>> Handle(GetTripsByDriverQuery request, CancellationToken cancellationToken)
        {
            var trips = await _tripRepository.GetTripsByDriverAsync(request.DriverId);

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