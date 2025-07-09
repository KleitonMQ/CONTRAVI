using CONTRAVI.Application.ViewModels;
using MediatR;


namespace CONTRAVI.Application.Queries.GetPassengerByName
{
    public class GetPassengerByNameQuery : IRequest<List<GetPassengerViewModel>>
    {
        public string Name { get; set; }
        public GetPassengerByNameQuery(string name) { Name = name; }
    }
}
