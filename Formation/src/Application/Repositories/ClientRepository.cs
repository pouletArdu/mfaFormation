namespace Application.Repositories;

public interface ClientRepository
{
    Task<int> Add(ClientDto client);
}