using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.Application.Queries.GetDriverByName
{
    public class GetDriverByNameQueryHandler : IRequestHandler<GetDriverByNameQuery, List<GetDriverViewModel>>
    {
        private readonly IDriverRepository _driverRepository;
        public GetDriverByNameQueryHandler(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }
        async Task<List<GetDriverViewModel>> IRequestHandler<GetDriverByNameQuery, List<GetDriverViewModel>>.Handle(GetDriverByNameQuery request, CancellationToken cancellationToken)
        {
            var drivers = await _driverRepository.GetDriverByNameAsync(request.UserName);

            var driverViewModel = drivers.Select(d => new GetDriverViewModel(d.UserName, d.PhoneNumber, d.Email, d.CNH, d.Adress)).ToList();

            return driverViewModel;
        }
    }
}
