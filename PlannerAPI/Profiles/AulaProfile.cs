using AutoMapper;
using PlannerAPI.Data.Dtos.Aula;
using PlannerAPI.Models;

namespace PlannerAPI.Profiles
{
    public class AulaProfile : Profile
    {
        public AulaProfile()
        {
            CreateMap<CreateAulaDto, Aula>();
            CreateMap<UpdateAulaDto, Aula>();
            CreateMap<Aula, ReadAulaDto>();
        }
    }
}
