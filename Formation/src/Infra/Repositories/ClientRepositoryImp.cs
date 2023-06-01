using Appllication.Commons.Exceptions;
using Domain.Models;

namespace Infra.Repositories;

public class ClientRepositoryImp : AbstractRepositoryImp, ClientRepository
{
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

    public async Task Delete(int id)
    {
        var entity = await _context.Clients.FindAsync(id);

        if (entity is null)
        {
            throw new NotFoundException();
        }

        _context.Clients.Remove(entity);

        await _context.SaveChangesAsync();
    }

    public async Task<ClientDto> GetOne(int id)
    {
        var client = await _context.Clients.FindAsync(id);
        return _mapper.Map<ClientDto>(client);
    }
}
