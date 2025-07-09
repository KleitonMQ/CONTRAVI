
using MediatR;

namespace CONTRAVI.Application.Commands.VehicleCommands.AddVehicle
{
    public class AddVehicleCommand : IRequest<Unit>
    {
        public int VehicleId { get; private set; }
        public string Model { get; private set; }
        public string LicensePlate { get; private set; }
        public int Vacancies { get; private set; }

        public AddVehicleCommand(int vehicleId, string model, string licensePlate, int vacancies)
        {
            VehicleId = vehicleId;
            Model = model;
            LicensePlate = licensePlate;
            Vacancies = vacancies;
        }
    }
}
