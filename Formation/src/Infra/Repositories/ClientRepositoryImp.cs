using Domain.Models;

namespace Infra.Repositories;

public class ClientRepositoryImp : AbstractRepositoryImp, ClientRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public ClientRepositoryImp(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<int> Add(ClientDto client)
    {
        var clientEntity = _mapper.Map<Client>(client);
        _context.Clients.Add(clientEntity);
        await _context.SaveChangesAsync();
        return clientEntity.Id;
    }

    public async Task<IEnumerable<ClientDto>> GetAll()
    {
        await Task.Yield();
        var clients = _context.Clients;
        return _mapper.Map<IEnumerable<ClientDto>>(clients);
    }

    public async Task<ClientDto> GetOne(int id)
    {
        var client = await _context.Clients.FindAsync(id);
        return _mapper.Map<ClientDto>(client);
    }
}
