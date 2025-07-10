using CONTRAVI.Application.ViewModels;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripsByTripDate
{
    public class GetTripsByTripDateQuery : IRequest<List<TripViewModel>>
    {
        public DateTime TripDate { get; set; }

        public GetTripsByTripDateQuery(DateTime tripDate)
        {
            TripDate = tripDate;
        }
    }
}