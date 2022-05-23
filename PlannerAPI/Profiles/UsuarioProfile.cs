using AutoMapper;
using PlannerAPI.Data.Dtos;
using PlannerAPI.Model;

namespace PlannerAPI.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
            CreateMap<UpdateUsuarioDto, Usuario>();
            CreateMap<Usuario, ReadUsuarioDto>();
        }
    }
}
