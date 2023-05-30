namespace Appllication.Client;

public class GetOneClientRequest : IRequest<ClientDto>
{
    public int Id { get; set; }
}

public class GetOneClientRequestHandler : IRequestHandler<GetOneClientRequest, ClientDto>
{
    private readonly ClientRepository _clientRepository;

    public GetOneClientRequestHandler(ClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<ClientDto> Handle(GetOneClientRequest request, CancellationToken cancellationToken)
    {
        return await _clientRepository.GetOne(request.Id);
    }

}
