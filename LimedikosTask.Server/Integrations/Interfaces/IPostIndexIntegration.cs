using LimedikosTask.Server.Models;

namespace LimedikosTask.Server.Integrations.Interfaces;

public interface IPostCodeIntegration
{
    public string Get(Client client);
}