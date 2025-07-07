using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;


namespace CONTRAVI.Application.Queries.GetPassengerByCNS
{
    public class GetPassengerByCNSQueryHandler : IRequestHandler<GetPassengerByCNSQuery, GetPassengerViewModel>
    {
        private readonly IPassengerRepository _passengerRepository;

        GetPassengerByCNSQueryHandler(IPassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }

        public async Task<GetPassengerViewModel> Handle(GetPassengerByCNSQuery request, CancellationToken cancellationToken)
        {
            var passenger = await _passengerRepository.GetPassengerByCNSAsync(request.CNS);

            return new GetPassengerViewModel(passenger.UserName, passenger.PhoneNumber, passenger.Email, passenger.CNS, passenger.Adress);
        }
    }
}
