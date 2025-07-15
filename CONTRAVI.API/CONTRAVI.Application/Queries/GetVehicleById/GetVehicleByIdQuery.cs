using CONTRAVI.core.Entities;
using MediatR;

namespace CONTRAVI.Application.Queries.GetVehicleById
{
    public class GetVehicleByIdQuery : IRequest<Vehicle>
    {
        public int Id { get; set; }
        public GetVehicleByIdQuery(int id)
        {
            Id = id;
        }
    }
}
