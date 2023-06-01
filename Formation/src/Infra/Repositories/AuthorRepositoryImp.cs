using Domain.Models;

namespace Infra.Repositories;
public class AuthorRepositoryImp : AbstractRepositoryImp, AuthorRepository
{
    public AuthorRepositoryImp(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public Task<int> AddAuthor(AuthorDto author)
    {
        throw new NotImplementedException();
    }
}
