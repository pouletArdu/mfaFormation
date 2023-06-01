namespace Appllication.Repositories;

public interface AuthorRepository
{
    Task<int> AddAuthor(AuthorDto author);
    Task<IEnumerable<AuthorDto>> GetAll();
}
