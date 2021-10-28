using AutoMapper;
using study_dotnet5.Data.Dtos.Gerente;
using study_dotnet5.Models;

namespace study_dotnet5.Profiles
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>();
        }
    }
}
