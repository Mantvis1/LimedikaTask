using LimedikosTask.Server.Models;

namespace LimedikosTask.Server.Integrations.Interfaces;

public interface IPostRequestUrlBuilder
{
    string Build(Client client);
}