using CONTRAVI.Application.ViewModels;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripsByPassengerName
{
    public class GetTripsByPassengerNameQuery : IRequest<List<TripViewModel>>
    {
        public string PassengerName { get; set; }

        public GetTripsByPassengerNameQuery(string passengerName)
        {
            PassengerName = passengerName;
        }
    }
}