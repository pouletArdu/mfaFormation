namespace Appllication.Repositories;

public interface AuthorRepository
{
    Task<int> AddAuthor(AuthorDto author);
}
