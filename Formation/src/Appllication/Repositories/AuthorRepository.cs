namespace Appllication.Repositories;

public interface AuthorRepository
{
    Task<int> AddAuthor(AuthorDto author);

    Task<AuthorDto> GetOne(int id);
}
