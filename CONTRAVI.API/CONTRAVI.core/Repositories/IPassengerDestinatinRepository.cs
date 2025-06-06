using CONTRAVI.core.Entities;

namespace CONTRAVI.core.Repositories
{
    internal interface IPassengerDestinatinRepository
    {
        Task AddPassengerDestinationAsync(PassengerDestination admin);
        Task UpdatePassengerDestinationAsync(PassengerDestination admin);
        Task<PassengerDestination> GetPassengerDestinationNameAsync(string name);
        Task<PassengerDestination> GetPassengerDestinationCNSAsync(string cNS);
        Task DeletePassengerDestinationAsync(PassengerDestination admin);
    }
}
