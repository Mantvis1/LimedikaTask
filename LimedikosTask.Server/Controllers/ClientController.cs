using LimedikosTask.Server.Models;
using LimedikosTask.Server.Models.DTOs;
using LimedikosTask.Server.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LimedikosTask.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController(IClientService clientService) : ControllerBase
{

    private readonly IClientService _clientService = clientService;

    [HttpPost]
    public void AddAll(string path)
    {
        _clientService.AddFromFile(path);
    }

    [HttpPut]
    public void Put()
    {
        _clientService.UpdatePostCode();
    }

    [HttpGet]
    public IEnumerable<ClientDto> GetAll()
    {
        return _clientService.GetAll();
    }
}
