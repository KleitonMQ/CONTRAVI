using CONTRAVI.core.Entities;

namespace CONTRAVI.core.Repositories
{
    public interface IRoadMapRepository
    {
        Task AddRoadMapAsync(RoadMap roadMap);
        Task UpdateRoadMapAsync(RoadMap roadMap, int id);
        Task DeleteRoadMapAsync(int id);
        Task<List<RoadMap>> GetRoadMapByDestinationAsync(string destination);
        Task<RoadMap> GetRoadMapByIDAsync(int id);

    }
}
