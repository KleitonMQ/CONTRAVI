using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONTRAVI.Infrascruture.Persistence.Repositories
{
    public class TripRepository : ITripRepository
    {
        private readonly CONTRAVIDBContext _dbContext;

        public TripRepository(CONTRAVIDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddTripAsync(Trip trip)
        {
            await _dbContext.Trip.AddAsync(trip);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateTripAsync(Trip trip)
        {
            var existingTrip = await _dbContext.Trip.FindAsync(trip.Id);
            if (existingTrip == null) return;

            existingTrip.UpdateTrip(trip.DriverId, trip.DriverId, trip.RoadMapId, trip.DepartureTime, trip.TripDate);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteTripAsync(int id)
        {
            var trip = await _dbContext.Trip.FindAsync(id);
            if (trip == null) return false;

            _dbContext.Trip.Remove(trip);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Trip>> GetTripsByVehicleAsync(int vehicleId)
        {
            return await _dbContext.Trip
                .Where(t => t.VehicleId == vehicleId)
                .Include(t => t.Vehicle)
                .Include(t => t.Driver)
                .Include(t => t.RoadMap)
                .ToListAsync();
        }

        public async Task<List<Trip>> GetTripsByDriverAsync(int driverId)
        {
            return await _dbContext.Trip
                .Where(t => t.DriverId == driverId)
                .Include(t => t.Driver)
                .Include(t => t.RoadMap)
                .Include(t => t.Vehicle)
                .ToListAsync();
        }

        public async Task<List<Trip>> GetTripsByRoadMapAsync(int roadMapId)
        {
            return await _dbContext.Trip
                .Where(t => t.RoadMapId == roadMapId)
                .Include(t => t.RoadMap)
                .Include (t => t.Vehicle)
                .Include(t => t.Driver)
                .ToListAsync();
        }

        public async Task<List<Trip>> GetTripsByTripDateAsync(DateTime tripDate)
        {
            return await _dbContext.Trip
                .Where(t => t.TripDate.Date == tripDate.Date)
                .ToListAsync();
        }

        public async Task<Trip?> GetTripByIdAsync(int id)
        {
            return await _dbContext.Trip
                .Include(t => t.Driver)
                .Include(t => t.Vehicle)
                .Include(t => t.RoadMap)
                .Include(t => t.PassengerDestination)
                    .ThenInclude(pd => pd.Passenger)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<List<Trip>> GetTripsByPassengerNameAsync(string name)
        {
            return await _dbContext.Trip
                .Include(t => t.Driver)
                .Include(t => t.Vehicle)
                .Include(t => t.RoadMap)
                .Include(t => t.PassengerDestination)
                    .ThenInclude(pd => pd.Passenger)
                .Where(t => t.PassengerDestination.Any(pd => pd.Passenger.UserName.ToLower().Contains(name.ToLower())))
                .ToListAsync();
        }

        public async Task<List<Trip>> GetTripsByPassengerCNSAsync(string cns)
        {
            return await _dbContext.Trip
                .Include(t => t.Driver)
                .Include(t => t.Vehicle)
                .Include(t => t.RoadMap)
                .Include(t => t.PassengerDestination)
                    .ThenInclude(pd => pd.Passenger)
                .Where(t => t.PassengerDestination.Any(pd => pd.Passenger.CNS == cns))
                .ToListAsync();
        }

        public async Task RemovePassengerDestination(PassengerDestination destino)
        {
            _dbContext.PassengerDestination.Remove(destino);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddPassengerDestinationAsync(PassengerDestination destino)
        {
            _dbContext.PassengerDestination.Add(destino);
            await _dbContext.SaveChangesAsync();
        }
    }
}