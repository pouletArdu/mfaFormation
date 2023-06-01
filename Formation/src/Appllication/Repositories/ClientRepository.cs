namespace Appllication.Repositories;
public interface ClientRepository
{
    Task<int> Add(ClientDto client);
    Task<ClientDto> GetOne(int id);
    Task Delete(int id);
}
