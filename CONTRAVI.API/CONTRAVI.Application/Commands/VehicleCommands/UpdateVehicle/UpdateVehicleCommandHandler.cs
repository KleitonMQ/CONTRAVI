using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.VehicleCommands.UpdateVehicle
{
    public class UpdateVehicleCommandHandler : IRequestHandler<UpdateVehicleCommand, Unit>
    {
        private readonly IVehicleRepository _vehicleRepository;
        public UpdateVehicleCommandHandler(IVehicleRepository repository)
        {
            _vehicleRepository = repository;
        }
        public async Task<Unit> Handle(UpdateVehicleCommand request, CancellationToken cancellationToken)
        {
            await _vehicleRepository.UpdateVehicleAsync(new Vehicle(request.VehicleId, request.Model, request.LicensePlate, request.Vacancies));

            return Unit.Value;
        }
    }
}
