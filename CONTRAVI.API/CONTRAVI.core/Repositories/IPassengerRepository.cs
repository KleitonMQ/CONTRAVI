using CONTRAVI.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Repositories
{
    public interface IPassengerRepository
    {
        Task AddPassengerAsync(Passenger passenger);
        Task UpdatePassenger(Passenger passenger);
        Task<Passenger> GetPassengerByName(string name);
        Task<Passenger> GetPassengerByCNS(string cNS);
    }
}
