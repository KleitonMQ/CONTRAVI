using CONTRAVI.core.Entities;

namespace CONTRAVI.core.Repositories
{
    public interface IPassengerRepository
    {
        Task AddPassengerAsync(Passenger passenger);
        Task UpdatePassengerAsync(Passenger passenger);
        Task<Passenger> GetPassengerByNameAsync(string name);
        Task<Passenger> GetPassengerByCNSAsync(string cNS);
    }
}
