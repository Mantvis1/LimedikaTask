using AutoMapper;
using LimedikosTask.Server.Integrations.Interfaces;
using LimedikosTask.Server.Models;
using LimedikosTask.Server.Models.DTOs;
using LimedikosTask.Server.Repositories.Interfaces;
using LimedikosTask.Server.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace LimedikosTask.Server.Services;

public class ClientService(IClientRepository clientRepository, IFileReaderService fileReaderService, IMapper mapper, IPostCodeIntegration postCodeIntegration) : IClientService
{
    private readonly IClientRepository _clientRepository = clientRepository;
    private readonly IFileReaderService _fileReaderService = fileReaderService;
    private readonly IPostCodeIntegration _postCodeIntegration = postCodeIntegration;
    private readonly IMapper _mapper = mapper;

    public IEnumerable<ClientDto> GetAll()
    {
        var clients = _clientRepository.GetAll();

        return _mapper.Map<List<ClientDto>>(clients);
    }

    public void UpdatePostCode()
    {
        var clients = _clientRepository.GetAll();

        foreach (var client in clients)
        {
            if (client.PostCode.IsNullOrEmpty())
            {
                client.PostCode = _postCodeIntegration.Get(client);
                _clientRepository.Update(client);
            }
        }
    }

    public void AddFromFile(string path)
    {

        var clientsDtos = _fileReaderService.Read(path);
        var clients = _mapper.Map<List<Client>>(clientsDtos);

        foreach (var client in clients)
        {
            if (_clientRepository.Exists(client))
            {
                _clientRepository.Update(client);
            }
            else
            {
                _clientRepository.Add(client);
            }
        }

    }
}
