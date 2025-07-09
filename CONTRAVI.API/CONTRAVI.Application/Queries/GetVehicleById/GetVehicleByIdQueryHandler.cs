
using CONTRAVI.core.Entities;
using MediatR;

namespace CONTRAVI.Application.Queries.GetVehicleById
{
    internal class GetVehicleByIdQueryHandler : IRequestHandler<GetVehicleByIdQuery, Vehicle>
    {
        public Task<Vehicle> Handle(GetVehicleByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
