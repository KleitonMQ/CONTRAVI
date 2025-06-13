using CONTRAVI.core.Entities;

namespace CONTRAVI.core.Repositories
{
    public interface IPassengerDestinationRepository
    {
        Task AddPassengerDestinationAsync(PassengerDestination passengerDestination);
        Task UpdatePassengerDestinationAsync(PassengerDestination passengerDestination);
        Task<List<PassengerDestination>> GetPassengerDestinationNameAsync(string name);
        Task<PassengerDestination> GetPassengerDestinationCNSAsync(string cNS);
        Task<bool> DeletePassengerDestinationAsync(int id);
    }
}
