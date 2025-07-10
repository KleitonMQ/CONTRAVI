using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripsByPassengerCNS
{
    public class GetTripsByPassengerCNSQueryHandler : IRequestHandler<GetTripsByPassengerCNSQuery, List<TripViewModel>>
    {
        private readonly ITripRepository _tripRepository;

        public GetTripsByPassengerCNSQueryHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<List<TripViewModel>> Handle(GetTripsByPassengerCNSQuery request, CancellationToken cancellationToken)
        {
            var trips = await _tripRepository.GetTripsByPassengerCNSAsync(request.CNS);

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