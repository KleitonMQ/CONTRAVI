using CONTRAVI.core.Entities;

namespace CONTRAVI.core.Repositories
{
    public interface IDriverRepository
    {
        Task<string> AddDriverAsync(Driver driver);
        Task<string> UpdateDriverAsync(Driver driver);
        Task<List<Driver>> GetDriverByNameAsync(string name);
        Task<Driver> GetDriverByCNHAsync(string cNH);
        Task<Driver> GetDriverByLoginAsync(string login, string password);
    }
}
