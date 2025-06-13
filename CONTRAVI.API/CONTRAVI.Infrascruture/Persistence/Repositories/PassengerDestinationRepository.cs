using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONTRAVI.Infrascruture.Persistence.Repositories
{
    public class PassengerDestinationRepository : IPassengerDestinationRepository
    {
        private readonly CONTRAVIDBContext _dbContext;

        public PassengerDestinationRepository(CONTRAVIDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddPassengerDestinationAsync(PassengerDestination passengerDestination)
        {
            await _dbContext.AddAsync(passengerDestination);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeletePassengerDestinationAsync(int id)
        {
            var passengerDestination = await _dbContext.PassengerDestination.FindAsync(id);
            if (passengerDestination == null)
            {
                return false; // Indica que o registro não foi encontrado
            }

            if (passengerDestination == null)
            {
                return false; 
            }

            _dbContext.PassengerDestination.Remove(passengerDestination);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<PassengerDestination> GetPassengerDestinationCNSAsync(string cNS)
        {
            var existingDestination = await _dbContext.PassengerDestination.FirstOrDefaultAsync(d => d.Passenger.CNS == cNS);
            if (existingDestination == null) { return null; }

            return existingDestination;
        }

        public async Task<List<PassengerDestination>> GetPassengerDestinationNameAsync(string name)
        {
            var existingDestination = await (_dbContext.PassengerDestination.Where(p => p.Passenger.UserName == name)).ToListAsync();

            return existingDestination;
        }

        public async Task UpdatePassengerDestinationAsync(PassengerDestination passengerDestination)
        {
            var existingDestination = await _dbContext.PassengerDestination.FindAsync(passengerDestination.Id);
            if (existingDestination == null) { return; }

            existingDestination.Update(passengerDestination.Procedure, passengerDestination.Destination, passengerDestination.ScheduledTime);
            await _dbContext.SaveChangesAsync();
        }
    }
}
