using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.Application.Queries.GetDriverByCNH
{
    public class GetDriverByCNHQueryHandler : IRequestHandler<GetDriverByCNHQuery, GetDriverViewModel>
    {
        private readonly IDriverRepository _driverRepository;
        public GetDriverByCNHQueryHandler(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }
        public async Task<GetDriverViewModel> Handle(GetDriverByCNHQuery request, CancellationToken cancellationToken)
        {
            var driver = await _driverRepository.GetDriverByCNHAsync(request.CNH);

            return new GetDriverViewModel(driver.UserName, driver.PhoneNumber, driver.Email, driver.CNH, driver.Adress);
        }
    }
}
