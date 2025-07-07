using CONTRAVI.Application.ViewModels;
using MediatR;


namespace CONTRAVI.Application.Queries.GetPassengerByCNS
{
    public class GetPassengerByCNSQuery : IRequest<GetPassengerViewModel>
    {
        public string CNS;
        GetPassengerByCNSQuery(string cNS) => CNS = cNS;
    }
}
