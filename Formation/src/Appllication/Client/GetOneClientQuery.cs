using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appllication.Client
{
    public record GetOneClientQuery(int Id) : IRequest<ClientDto>
    {
    }

    public class GetOneClientCommandHandler : IRequestHandler<GetOneClientQuery, ClientDto>
    {
        private readonly ClientRepository _clientRepository;
        public GetOneClientCommandHandler(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<ClientDto> Handle(GetOneClientQuery request, CancellationToken cancellationToken)
        {
            return await _clientRepository.GetOne(request.Id);
        }
    }
    public class GetOneClientCommandValidator : AbstractValidator<GetOneClientQuery>
    {
        public GetOneClientCommandValidator()
        {
            RuleFor(v => v.Id)
                .NotNull().WithMessage("{PropertyName} is required.")
                .GreaterThan(0);
        }
    }
}
