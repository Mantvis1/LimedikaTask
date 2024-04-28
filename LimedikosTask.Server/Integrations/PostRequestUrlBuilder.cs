using LimedikosTask.Server.Integrations.Interfaces;
using LimedikosTask.Server.Models;

namespace LimedikosTask.Server.Integrations;

public class PostRequestUrlBuilder : IPostRequestUrlBuilder
{
    public string Build(Client client)
    {
        var clientAddress = client.Address.Split(" ");

        return $"https://api.postit.lt/v2/?city={clientAddress[3]}&address={clientAddress[0]}+{clientAddress[2].Replace(",", string.Empty)}&key=fhlCUSKQmpqU08sTHDug";
    }
}
