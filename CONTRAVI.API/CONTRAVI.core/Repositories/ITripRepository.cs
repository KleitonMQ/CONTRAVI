using CONTRAVI.core.Entities;


namespace CONTRAVI.core.Repositories
{
    public interface ITripRepository
    {
        Task AddTripAsync(Trip trip);
        Task UpdateTripAsync(Trip trip);
        Task<bool> DeleteTripAsync(int id);
        Task<List<Trip>> GetTripsByVehicleAsync(int vehicleId);
        Task<List<Trip>> GetTripsByDriverAsync(int driverId);
        Task<List<Trip>> GetTripsByRoadMapAsync(int roadMapId);
        Task<List<Trip>> GetTripsByTripDateAsync(DateTime tripDate);
        Task<List<Trip>> GetTripsByPassengerNameAsync(string name);
        Task<List<Trip>> GetTripsByPassengerCNSAsync(string cns);
        Task<Trip?> GetTripByIdAsync(int id);
    }
}
