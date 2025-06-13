using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONTRAVI.Infrascruture.Persistence.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly CONTRAVIDBContext _dbContext;
        public VehicleRepository(CONTRAVIDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddVehicleAsync(Vehicle vehicle)
        {
            await _dbContext.AddAsync(vehicle);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Vehicle> GetVehicleByIdAsync(int id)
        {
            var vehicle = await _dbContext.Vehicle.SingleOrDefaultAsync(x => x.VehicleId == id);
            if (vehicle == null) { return null; }

            return vehicle;
            
        }

        public async Task UpdateVehicleAsync(Vehicle vehicle)
        {
            var existingVehicle = await _dbContext.Vehicle.FindAsync(vehicle.Id);
            if (existingVehicle != null) { return; }

        }
    }
}
