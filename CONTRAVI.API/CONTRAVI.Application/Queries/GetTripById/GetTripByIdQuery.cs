using CONTRAVI.Application.ViewModels;
using MediatR;


namespace CONTRAVI.Application.Queries.GetTripById
{
    public class GetTripByIdQuery : IRequest<TripViewModel>
    {
        public int Id { get; set; }

        public GetTripByIdQuery(int id)
        {
            Id = id;
        }
    }

}
