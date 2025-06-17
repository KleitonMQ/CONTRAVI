using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetAdminByName
{
    public class GetAdminByNameQueryHandler : IRequestHandler<GetAdminByNameQuery, List<GetAdminViewModel>>
    {
        private readonly IAdminRepository _adminRepository;
        public GetAdminByNameQueryHandler(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public async Task<List<GetAdminViewModel>> Handle(GetAdminByNameQuery request, CancellationToken cancellationToken)
        {
            var admins = await _adminRepository.GetAdminByNameAsync(request.UserName);
            var adminViewModel = admins.Select(p => new GetAdminViewModel(p.UserName, p.PhoneNumber, p.Email, p.Adress)).ToList();

            return adminViewModel;
        }
    }
}
