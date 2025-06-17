using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Entities;
using MediatR;

namespace CONTRAVI.Application.Queries.GetDriverByName
{
    public class GetDriverByNameQuery : IRequest<List<GetDriverViewModel>>
    {
        public GetDriverByNameQuery(string username)
        {
            UserName = username;
        }
        public string UserName { get; set; }

    }
}
