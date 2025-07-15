
using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Queries.GetVehicleById
{
    public class GetVehicleByIdQueryHandler : IRequestHandler<GetVehicleByIdQuery, Vehicle>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public GetVehicleByIdQueryHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public async Task<Vehicle> Handle(GetVehicleByIdQuery request, CancellationToken cancellationToken)
        {
            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(request.Id);
            return vehicle;
        }
    }
}
