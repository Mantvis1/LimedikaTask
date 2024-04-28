using AutoMapper;
using LimedikosTask.Server.Models;
using LimedikosTask.Server.Models.DTOs;

namespace LimedikosTask;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Client, ClientDto>()
            .ReverseMap();
    }
}