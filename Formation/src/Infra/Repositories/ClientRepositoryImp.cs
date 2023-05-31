using Application.Repositories;
using AutoMapper;
using Domain.Models;
using Infra.Entities;
using Infra.Persistence;

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
        var entity = _mapper.Map<Client>(client);

        _context.Clients.Add(entity);

        await _context.SaveChangesAsync();

        return entity.Id;
    }

    public async Task<ClientDto> GetOne(int id)
    {
        var client = await _context.Clients.FindAsync(id);

        return _mapper.Map<ClientDto>(client);
    }
}