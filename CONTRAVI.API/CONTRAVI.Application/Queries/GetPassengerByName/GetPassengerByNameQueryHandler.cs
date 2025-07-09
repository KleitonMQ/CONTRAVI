using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetPassengerByName
{
    public class GetPassengerByNameQueryHandler : IRequestHandler<GetPassengerByNameQuery, List<GetPassengerViewModel>>
    {
        private readonly IPassengerRepository _passengerRepository;

        public GetPassengerByNameQueryHandler(IPassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }
        public async Task<List<GetPassengerViewModel>> Handle(GetPassengerByNameQuery request, CancellationToken cancellationToken)
        {
            var results = await _passengerRepository.GetPassengerByNameAsync(request.Name);

            return results.Select(pa => new GetPassengerViewModel(pa.UserName, pa.PhoneNumber, pa.Email, pa.CNS, pa.Adress)).ToList();
        }
    }
}
