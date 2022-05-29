using AutoMapper;
using PlannerAPI.Data.Dtos.Aula;
using PlannerAPI.Model;

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
