using CONTRAVI.core.Entities;

namespace CONTRAVI.core.Repositories
{
    public interface IDriverRepository
    {
        Task<String> AddDriverAsync(Driver driver);
        Task<String> UpdateDriverAsync(Driver driver);
        Task<List<Driver>> GetDriverByNameAsync(string name);
        Task<Driver> GetDriverByCNHAsync(string cNH);
    }
}
