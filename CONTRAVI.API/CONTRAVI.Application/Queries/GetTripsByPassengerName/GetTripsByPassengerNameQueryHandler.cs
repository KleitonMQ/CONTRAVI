using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripsByPassengerName
{
    public class GetTripsByPassengerNameQueryHandler : IRequestHandler<GetTripsByPassengerNameQuery, List<TripViewModel>>
    {
        private readonly ITripRepository _tripRepository;

        public GetTripsByPassengerNameQueryHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<List<TripViewModel>> Handle(GetTripsByPassengerNameQuery request, CancellationToken cancellationToken)
        {
            var trips = await _tripRepository.GetTripsByPassengerNameAsync(request.PassengerName);

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