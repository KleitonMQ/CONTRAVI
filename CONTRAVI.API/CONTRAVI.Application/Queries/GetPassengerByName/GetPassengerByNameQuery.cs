using CONTRAVI.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.Application.Queries.GetPassengerByName
{
    public class GetPassengerByNameQuery : IRequest<List<GetPassengerViewModel>>
    {
        public string Name { get; set; }
        public GetPassengerByNameQuery(string name) { Name = name; }
    }
}
