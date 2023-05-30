using Domain.Models;

namespace Infra.Repositories;

public class ClientRepositoryImp : ClientRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public ClientRepositoryImp(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Add(ClientDto client)
    {
        var clientEntity = _mapper.Map<Client>(client);
        _context.Clients.Add(clientEntity);
        await _context.SaveChangesAsync();
        return clientEntity.Id;
    }

    public async Task<ClientDto> GetOne(int id)
    {
        var client = await _context.Clients.FindAsync(id);
        return _mapper.Map<ClientDto>(client);
    }
}
