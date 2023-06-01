namespace Appllication.Client;

public record GetAllClientsQuery : IRequest<IEnumerable<ClientDto>>
{
}

public class GetAllClientsQueryHandler : IRequestHandler<GetAllClientsQuery, IEnumerable<ClientDto>>
{
    public ClientRepository _clientRepository { get; }

    public GetAllClientsQueryHandler(ClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<IEnumerable<ClientDto>> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
    {
        return await _clientRepository.GetAll();
    }
}