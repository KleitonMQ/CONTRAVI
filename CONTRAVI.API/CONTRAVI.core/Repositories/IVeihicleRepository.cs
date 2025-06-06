using CONTRAVI.core.Entities;

namespace CONTRAVI.core.Repositories
{
    public interface IVeihicleRepository
    {
        Task AddVehicleAsync(Vehicle passenger);
        Task UpdateVehicleAsync(Vehicle passenger);
        Task<Vehicle> GetVehicleByIdAsync(int id);
    }
}
