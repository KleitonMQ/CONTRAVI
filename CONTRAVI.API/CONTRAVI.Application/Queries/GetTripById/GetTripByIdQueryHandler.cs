using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripById
{
    public class GetTripByIdQueryHandler : IRequestHandler<GetTripByIdQuery, TripViewModel>
    {
        private readonly ITripRepository _tripRepository;

        public GetTripByIdQueryHandler(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public async Task<TripViewModel> Handle(GetTripByIdQuery request, CancellationToken cancellationToken)
        {
            var trip = await _tripRepository.GetTripByIdAsync(request.Id);

            if (trip == null) return null;

            return new TripViewModel(
                trip.Id,
                trip.Driver?.UserName,
                trip.Vehicle?.Model,
                trip.RoadMap?.Destination,
                trip.DepartureTime,
                trip.TripDate
            );
        }
    }
}