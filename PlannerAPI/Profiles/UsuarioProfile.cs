using AutoMapper;
using PlannerAPI.Data.Dtos.Usuario;
using PlannerAPI.Models;

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
