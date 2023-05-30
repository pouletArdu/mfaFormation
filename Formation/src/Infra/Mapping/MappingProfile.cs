global using AutoMapper;

namespace Infra.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, Domain.Models.ClientDto>().ReverseMap();
        }
    }
}
