using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.Application.Queries.GetAdminByName
{
    internal class GetadminByNameQueryHandler : IRequestHandler<GetAdminByNameQuery, List<GetAdminViewModel>>
    {
        private readonly IAdminRepository _adminRepository;
        public GetadminByNameQueryHandler(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public async Task<List<GetAdminViewModel>> Handle(GetAdminByNameQuery request, CancellationToken cancellationToken)
        {
            var admins = await _adminRepository.GetAdminByNameAsync(request.Query);
            var adminViewModel = admins.Select(p => new GetAdminViewModel(p.UserName, p.PhoneNumber, p.Email, p.Adress)).ToList();

            return adminViewModel;
        }
    }
}
