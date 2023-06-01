using Domain.Models;
using Appllication.Repositories;

namespace Infra.Repositories;

public class AuthorRepositoryImp : AbstractRepositoryImp, AuthorRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public AuthorRepositoryImp(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public Task<int> AddAuthor(AuthorDto author)
    {
        throw new NotImplementedException();
    }

    public async Task<AuthorDto> GetOne(int id)
    {
        var author = await _context.Authors.FindAsync(id);
        return _mapper.Map<AuthorDto>(author);
    }
}
