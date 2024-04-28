using LimedikosTask.Server.Integrations.Interfaces;
using LimedikosTask.Server.Models;
using Newtonsoft.Json;
using RestSharp;

namespace LimedikosTask.Server.Integrations;

public class PostCodeIntegration(IPostRequestUrlBuilder postRequestUrlBuilder) : IPostCodeIntegration
{
    private readonly IPostRequestUrlBuilder _postRequestUrlBuilder = postRequestUrlBuilder;

    public string Get(Client client)
    {
        var options = new RestClientOptions(_postRequestUrlBuilder.Build(client));
        var restClient = new RestClient(options);
        var request = new RestRequest();
        var response = restClient.Get(request);
        var result = JsonConvert.DeserializeObject<Root>(response.Content);

        return $"LT-{result.Data[0].PostCode}";
    }
}
