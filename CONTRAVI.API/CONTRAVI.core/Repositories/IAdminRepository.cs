using CONTRAVI.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Repositories
{
    internal interface IAdminRepository
    {
        Task AddAdminAsync(Admin admin);
        Task UpdateAdmin(Admin admin);
        Task<Admin> GetAdminByName(string name);
        Task<Admin> GetAdminByLogin(string cNH);
    }
}
