using CONTRAVI.core.Entities;

namespace CONTRAVI.core.Repositories
{
    public interface IDriverRepository
    {
        Task AddDriverAsync(Driver driver);
        Task UpdateDriverAsync(Driver driver);
        Task<Driver> GetDriverByNameAsync(string name);
        Task<Driver> GetDriverByCNHAsync(string cNH);
    }
}
