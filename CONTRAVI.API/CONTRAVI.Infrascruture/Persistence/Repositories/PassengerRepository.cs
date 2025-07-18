﻿using System.Net;
using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONTRAVI.Infrascruture.Persistence.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly CONTRAVIDBContext _dbContext;
        public PassengerRepository(CONTRAVIDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddPassengerAsync(Passenger passenger)
        {
            await _dbContext.AddRangeAsync(passenger);
            await _dbContext.SaveChangesAsync();
            return passenger.UserName;
        }

        public async Task<Passenger> GetPassengerByCNSAsync(string cNS)
        {
            var existingPassenger = await _dbContext.Passenger.FirstOrDefaultAsync(p => p.CNS == cNS);
            
            if (existingPassenger == null) { return null; }
            
            return existingPassenger;
        }

        public async Task<List<Passenger>> GetPassengerByNameAsync(string name)
        {
            return await _dbContext.Passenger
                .Where(p => p.UserName.ToLower().Contains(name.ToLower()))
                .ToListAsync();
        }

        public async Task<string> UpdatePassengerAsync(Passenger passenger)
        {
            var existingPassenger = await _dbContext.Passenger.FirstOrDefaultAsync(p => p.CNS == passenger.CNS);
            if (existingPassenger == null) { return "Passageiro não encontrado."; }

            existingPassenger.Update(passenger.UserName, passenger.PhoneNumber, passenger.Email, passenger.CNS, passenger.Adress);

            return existingPassenger.UserName;

        }
    }
}
