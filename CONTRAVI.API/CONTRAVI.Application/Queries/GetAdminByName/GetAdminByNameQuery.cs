using CONTRAVI.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.Application.Queries.GetAdminByName
{
    internal class GetAdminByNameQuery : IRequest<List<GetAdminViewModel>>
    {
        public GetAdminByNameQuery(string query) { Query = query; }

        public string Query { get; private set; }
    }
}
