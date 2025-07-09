using CONTRAVI.Application.ViewModels;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetPassengerDestinationByName
{
    public class GetPassengerDestinationByNameQueryHandler : IRequestHandler<GetPassengerDestinationByNameQuery, List<PassengerDestinationViewModel>>
    {
        private readonly IPassengerDestinationRepository _repository;
        public GetPassengerDestinationByNameQueryHandler(IPassengerDestinationRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<PassengerDestinationViewModel>> Handle(GetPassengerDestinationByNameQuery request, CancellationToken cancellationToken)
        {
            var results = await _repository.GetPassengerDestinationNameAsync(request.Name);

            return results.Select(pd => new PassengerDestinationViewModel(pd.Id, pd.Destination, pd.Procedure, pd.ScheduledTime)).ToList();
        }
    }
}
