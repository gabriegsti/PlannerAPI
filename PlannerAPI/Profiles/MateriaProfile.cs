using AutoMapper;
using PlannerAPI.Data.Dtos.Materia;
using PlannerAPI.Models;

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
