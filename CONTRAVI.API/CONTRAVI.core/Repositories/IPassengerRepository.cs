using CONTRAVI.core.Entities;

namespace CONTRAVI.core.Repositories
{
    public interface IPassengerRepository
    {
        Task<string> AddPassengerAsync(Passenger passenger);
        Task<string> UpdatePassengerAsync(Passenger passenger);
        Task<List<Passenger>> GetPassengerByNameAsync(string name);
        Task<Passenger> GetPassengerByCNSAsync(string cNS);
    }
}
