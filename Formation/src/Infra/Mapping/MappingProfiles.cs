using AutoMapper;
using Domain.Models;
using Infra.Entities;

namespace Infra.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Client, ClientDto>().ReverseMap();
    }
}