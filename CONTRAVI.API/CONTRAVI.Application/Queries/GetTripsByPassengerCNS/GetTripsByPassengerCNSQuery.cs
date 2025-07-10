using CONTRAVI.Application.ViewModels;
using MediatR;

namespace CONTRAVI.Application.Queries.GetTripsByPassengerCNS
{
    public class GetTripsByPassengerCNSQuery : IRequest<List<TripViewModel>>
    {
        public string CNS { get; set; }

        public GetTripsByPassengerCNSQuery(string cns)
        {
            CNS = cns;
        }
    }
}