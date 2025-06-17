using CONTRAVI.Application.ViewModels;
using MediatR;

namespace CONTRAVI.Application.Queries.GetAdminByName
{
    public class GetAdminByNameQuery : IRequest<List<GetAdminViewModel>>
    {
        public GetAdminByNameQuery(string query) { UserName = query; }

        public string UserName { get; private set; }
    }
}
