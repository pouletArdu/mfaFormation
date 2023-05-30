namespace Appllication.Repositories;
public interface AuthorRepository
{
    Task<int> Add(AuthorDto author);

    Task<ClientDto> GetOne(int id);

    Task<bool> Delete(int id);
}
