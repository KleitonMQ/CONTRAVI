using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONTRAVI.Infrascruture.Persistence.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        private readonly CONTRAVIDBContext _dbContext;
        public DriverRepository(CONTRAVIDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<String> AddDriverAsync(Driver driver)
        {
            await _dbContext.AddAsync(driver);
            await _dbContext.SaveChangesAsync();
            return driver.UserName;
        }

        public async Task<Driver> GetDriverByCNHAsync(string cNH)
        {
            return await _dbContext.Driver.SingleOrDefaultAsync(d => d.CNH == cNH);
        }

        public Task<Driver> GetDriverByLoginAsync(string login, string password)
        {
            return _dbContext.Driver.SingleOrDefaultAsync(d => d.Login == login && d.Password == password);
        }

        public async Task<List<Driver>> GetDriverByNameAsync(string name)
        {
            return await _dbContext.Driver.Where(d => d.UserName.ToLower() == name.ToLower()).ToListAsync();
        }

        public async Task<string> UpdateDriverAsync(Driver driver)
        {
            var existingDriver = await _dbContext.Driver.FindAsync(driver.Id);
            if (existingDriver == null)
            {
                return "Motorista não encontrado.";
            }

            existingDriver.Update(driver.UserName, driver.PhoneNumber, driver.Email, driver.CNH, driver.Password, driver.Adress, driver.Login);

            await _dbContext.SaveChangesAsync();
            return $"{driver.UserName} atualizado com sucesso!";
        }
    }
}
