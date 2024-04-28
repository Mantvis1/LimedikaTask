using LimedikosTask.Server.Models;
using LimedikosTask.Server.Models.DTOs;

namespace LimedikosTask.Server.Services.Interfaces
{
    public interface IFileReaderService
    {
        List<ClientDto> Read(string path);
    }
}