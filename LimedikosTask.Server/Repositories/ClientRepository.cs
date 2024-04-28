using EFCoreInMemoryDbDemo;
using LimedikosTask.Server.Logging;
using LimedikosTask.Server.Models;
using LimedikosTask.Server.Repositories.Interfaces;

namespace LimedikosTask.Server.Repositories;

public class ClientRepository(ApiContext context, ICustomLogger customLogger) : IClientRepository
{
    private readonly ApiContext _context = context;
    private readonly ICustomLogger _customLogger = customLogger;

    public void Add(Client client)
    {
        _context.Clients.Add(client);
        _context.SaveChanges();

        _customLogger.Log($"Client '{client.Name}' was created");
    }

    public void Update(Client client)
    {
        _context.Clients.Update(client);
        _context.SaveChanges();

        _customLogger.Log($"Client '{client.Name}' was updated");

    }

    public bool Exists(Client client)
    {
        return _context
            .Clients
            .Any(x => x.Name == client.Name);
    }

    public List<Client> GetAll()
    {
        return
            [.. _context
            .Clients];
    }
}
