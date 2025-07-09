

using MediatR;

namespace CONTRAVI.Application.Commands.VehicleCommands.UpdateVehicle
{
    public class UpdateVehicleCommand : IRequest<Unit>
    {
        public int VehicleId { get; private set; }
        public string Model { get; private set; }
        public string LicensePlate { get; private set; }
        public int Vacancies { get; private set; }

        public UpdateVehicleCommand(int vehicleId, string model, string licensePlate, int vacancies)
        {
            VehicleId = vehicleId;
            Model = model;
            LicensePlate = licensePlate;
            Vacancies = vacancies;
        }
    }
}
