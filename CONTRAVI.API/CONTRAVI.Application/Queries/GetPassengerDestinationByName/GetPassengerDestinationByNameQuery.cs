using CONTRAVI.Application.ViewModels;
using MediatR;

namespace CONTRAVI.Application.Queries.GetPassengerDestinationByName
{

    public class GetPassengerDestinationByNameQuery : IRequest<List<PassengerDestinationViewModel>>
    {
        public string Name { get; private set; }
        public GetPassengerDestinationByNameQuery(string name) => Name = name;
    }
}
