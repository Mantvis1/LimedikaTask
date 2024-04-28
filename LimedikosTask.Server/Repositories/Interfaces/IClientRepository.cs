using LimedikosTask.Server.Models;

namespace LimedikosTask.Server.Repositories.Interfaces;

public interface IClientRepository
{
    bool Exists(Client client);
    void Add(Client client);
    void Update(Client client);
    public List<Client> GetAll();
}