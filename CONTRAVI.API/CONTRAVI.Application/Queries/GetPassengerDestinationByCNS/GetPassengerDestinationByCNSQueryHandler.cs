using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetPassengerDestinationByCNS
{
    public class GetPassengerDestinationByCNSQueryHandler : IRequestHandler<GetPassengerDestinationByCNSQuery, PassengerDestinationViewModel>
    {
        private readonly IPassengerDestinationRepository _repository;
        public GetPassengerDestinationByCNSQueryHandler(IPassengerDestinationRepository repository)
        {
            _repository = repository;
        }

        public async Task<PassengerDestinationViewModel> Handle(GetPassengerDestinationByCNSQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetPassengerDestinationCNSAsync(request.CNS);
            return new PassengerDestinationViewModel(entity.Id, entity.Destination, entity.Procedure, entity.ScheduledTime);
        }
    }
}
