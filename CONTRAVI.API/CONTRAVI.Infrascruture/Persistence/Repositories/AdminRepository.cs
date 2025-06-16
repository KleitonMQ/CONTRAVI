using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONTRAVI.Infrascruture.Persistence.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly CONTRAVIDBContext _DBContext;

        public AdminRepository(CONTRAVIDBContext DBContext)
        {
            _DBContext = DBContext;
        }
        public async Task<String> AddAdminAsync(Admin admin)
        {
            await _DBContext.Admin.AddAsync(admin);
            await _DBContext.SaveChangesAsync();
            return admin.UserName;
        }

        public async Task<Admin> GetAdminByLoginAndPasswordAsync(string login, string password)
        {
            return await _DBContext.Admin.SingleOrDefaultAsync(u => u.Login == login && u.Password == password);
        }

        public async Task<List<Admin>> GetAdminByNameAsync(string name)
        {
            return await _DBContext.Admin
                         .Where(a => a.UserName.ToLower() == name.ToLower())
                         .ToListAsync();
        }

        public async Task<string> UpdateAdminAsync(Admin admin)
        {
            var existingAdmin = await _DBContext.Admin.SingleOrDefaultAsync(u => u.Login == admin.Login);
            if (existingAdmin == null)
            {
                return "Admin não encontrado.";
            }

            existingAdmin.Update(admin.UserName, admin.PhoneNumber, admin.Email, admin.Login, admin.Password, admin.Adress);
            
            await _DBContext.SaveChangesAsync();
            return $"{admin.UserName} atualizado com sucesso!";
        }

    }
}
