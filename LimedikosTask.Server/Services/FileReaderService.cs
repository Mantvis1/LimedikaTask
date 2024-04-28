using LimedikosTask.Server.Models.DTOs;
using LimedikosTask.Server.Services.Interfaces;
using Newtonsoft.Json;

namespace LimedikosTask.Server.Services;

public class JsonFileReaderService : IFileReaderService
{
    private readonly string basePath = @"C:\Users\Lenovo\Desktop\Projects\LimedikosTask\LimedikosTask.Server\Data\";
    public List<ClientDto> Read(string path)
    {
        var clients = new List<ClientDto>();

        if (!path.EndsWith(".json"))
        {
            return clients;
        }

        using (var reader = new StreamReader($"{basePath}{path}"))
        {
            clients = JsonConvert.DeserializeObject<List<ClientDto>>(reader.ReadToEnd());
        }

        return clients;
    }
}
