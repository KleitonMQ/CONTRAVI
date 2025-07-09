using CONTRAVI.core.Entities;

namespace CONTRAVI.core.Repositories
{
    public interface IRoadMapRepository
    {
        Task AddRoadMapAsync(RoadMap roadMap);
        Task UpdateRoadMapAsync(RoadMap roadMap);
        Task DeleteRoadMapAsync(int id);
        Task<List<RoadMap>> GetRoadMapByDestinationAsync(string destination);

    }
}
