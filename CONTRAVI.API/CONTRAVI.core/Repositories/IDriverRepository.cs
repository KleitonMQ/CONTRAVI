using CONTRAVI.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Repositories
{
    public interface IDriverRepository
    {
        Task AddDriverAsync(Driver driver);
        Task UpdateDriver(Driver driver);
        Task<Driver> GetDriverByName(string name);
        Task<Driver> GetDriverByCNH(string cNH);
    }
}
