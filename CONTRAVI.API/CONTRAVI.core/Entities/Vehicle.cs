using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    public class Vehicle : BaseEntity
    {
        public Vehicle(int vehicleId, string model, string licensePlate, int vacancies)
        {
            VehicleId = vehicleId;
            Model = model;
            LicensePlate = licensePlate;
            Vacancies = vacancies;
        }
        public int VehicleId { get; private set; }
        public string Model { get; private set; }
        public string LicensePlate { get; private set; }
        public int Vacancies { get; private set; }
    }
}
