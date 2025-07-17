using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CONTRAVI.Infrascruture.Persistence.Repositories
{
    public class RoadMapRepository : IRoadMapRepository
    {
        private readonly CONTRAVIDBContext _dbContext;
        public RoadMapRepository(CONTRAVIDBContext context)
        {
            _dbContext = context;
        }
        public async Task AddRoadMapAsync(RoadMap roadMap)
        {
            await _dbContext.AddAsync(roadMap);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteRoadMapAsync(int id)
        {
            var existingRoadMap = await _dbContext.Roads.FindAsync(id);
            if (existingRoadMap == null) {return; }
            _dbContext.Remove(existingRoadMap);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<RoadMap>> GetRoadMapByDestinationAsync(string destination)
        {
            var destinations = await _dbContext.Roads.Where(p => p.Destination.ToLower().Contains(destination.ToLower())).ToListAsync();
            return destinations;

        }

        public async Task<RoadMap> GetRoadMapByIDAsync(int id)
        {
            return await _dbContext.Roads.FindAsync(id);
        }

        public async Task UpdateRoadMapAsync(RoadMap roadMap, int id)
        {
            var existingRoadMap = await _dbContext.Roads.FindAsync(id);
            if (existingRoadMap == null)
            {
                return;
            }
            existingRoadMap.Update(roadMap.Departure, roadMap.Destination, roadMap.Arrival);
            await _dbContext.SaveChangesAsync();
        }
    }
}
