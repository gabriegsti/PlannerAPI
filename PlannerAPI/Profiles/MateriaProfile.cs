using AutoMapper;
using PlannerAPI.Data.Dtos.Materia;
using PlannerAPI.Model;

namespace PlannerAPI.Profiles
{
    public class MateriaProfile : Profile
    {
        public MateriaProfile()
        {
            CreateMap<CreateMateriaDto, Materia>();
            CreateMap<UpdateMateriaDto, Materia>();
            CreateMap<Materia, ReadMateriaDto>();
        }
    }
}
