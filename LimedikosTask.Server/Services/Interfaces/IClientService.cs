using LimedikosTask.Server.Models.DTOs;

namespace LimedikosTask.Server.Services.Interfaces;

public interface IClientService
{
    IEnumerable<ClientDto> GetAll();
    void UpdatePostCode();
    void AddFromFile(string path);
}