using CONTRAVI.core.Entities;
using CONTRAVI.core.Repositories;
using MediatR;

namespace CONTRAVI.Application.Commands.CreateDriver
{
    public class CreateDriverCommandHandler : IRequestHandler<CreateDriverCommand, string>
    {
        private readonly IDriverRepository _driverRepository;

        public CreateDriverCommandHandler(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }
        public async Task<string> Handle(CreateDriverCommand request, CancellationToken cancellationToken)
        {
            return await _driverRepository.AddDriverAsync(new Driver(request.UserName, request.PhoneNumber, request.Email, request.Address, request.CNH, request.Password, request.Login));
        }
    }
}
