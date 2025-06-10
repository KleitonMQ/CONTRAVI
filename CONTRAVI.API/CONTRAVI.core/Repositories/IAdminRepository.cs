using CONTRAVI.core.Entities;


namespace CONTRAVI.core.Repositories
{
    public interface IAdminRepository
    {
        Task<String> AddAdminAsync(Admin admin);
        Task<String> UpdateAdminAsync(Admin admin);
        Task<List<Admin>> GetAdminByNameAsync(string name);
        Task<Admin> GetAdminByLoginAndPasswordAsync(string login, string password);
    }
}
