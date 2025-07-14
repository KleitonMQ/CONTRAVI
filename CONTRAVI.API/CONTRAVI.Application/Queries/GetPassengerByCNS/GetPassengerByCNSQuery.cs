using CONTRAVI.Application.ViewModels;
using MediatR;


namespace CONTRAVI.Application.Queries.GetPassengerByCNS
{
    public class GetPassengerByCNSQuery : IRequest<GetPassengerViewModel>
    {
        public string CNS;
        public GetPassengerByCNSQuery(string cNS) => CNS = cNS;
    }
}
