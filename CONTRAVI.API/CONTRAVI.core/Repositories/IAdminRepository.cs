using CONTRAVI.core.Entities;


namespace CONTRAVI.core.Repositories
{
    public interface IAdminRepository
    {
        Task AddAdminAsync(Admin admin);
        Task UpdateAdminAsync(Admin admin);
        Task<Admin> GetAdminByNameAsync(string name);
        Task<Admin> GetAdminByLoginAsync(string cNH);
    }
}
