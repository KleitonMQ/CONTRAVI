using CONTRAVI.Application.ViewModels;
using MediatR;

namespace CONTRAVI.Application.Queries.GetPassengerDestinationByCNS
{
    public class GetPassengerDestinationByCNSQuery : IRequest<PassengerDestinationViewModel>
    {
        public string CNS { get; private set; }
        public GetPassengerDestinationByCNSQuery(string cns) => CNS = cns;
    }
}
