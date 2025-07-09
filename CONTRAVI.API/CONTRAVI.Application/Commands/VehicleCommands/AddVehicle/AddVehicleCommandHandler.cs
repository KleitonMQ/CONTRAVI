using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;


namespace CONTRAVI.Application.Commands.VehicleCommands.AddVehicle
{
    public class AddVehicleCommandHandler : IRequestHandler<AddVehicleCommand, Unit>
    {
        private readonly IVehicleRepository _vehicleRepository;
        public AddVehicleCommandHandler(IVehicleRepository repository)
        {
            _vehicleRepository = repository;
        }
        public async Task<Unit> Handle(AddVehicleCommand request, CancellationToken cancellationToken)
        {
            await _vehicleRepository.AddVehicleAsync(new Vehicle(request.VehicleId, request.Model, request.LicensePlate, request.Vacancies));
            
            return Unit.Value;
        }
    }
}
