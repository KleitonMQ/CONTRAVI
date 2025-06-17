using CONTRAVI.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.Application.Queries.GetDriverByCNH
{
    public class GetDriverByCNHQuery : IRequest<GetDriverViewModel>
    {
        public GetDriverByCNHQuery(string cnh)
        {
            CNH = cnh;
        }
        public string CNH {  get; set; }
    }
}
