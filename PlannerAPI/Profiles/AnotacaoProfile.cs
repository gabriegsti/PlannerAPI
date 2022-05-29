using AutoMapper;
using PlannerAPI.Data.Dtos.Anotacao;
using PlannerAPI.Model;

namespace PlannerAPI.Profiles
{
    public class AnotacaoProfile : Profile
    {
        public AnotacaoProfile()
        {
            CreateMap<CreateAnotacaoDto, Anotacao>();
            CreateMap<UpdateAnotacaoDto, Anotacao>();
            CreateMap<Anotacao, ReadAnotacaoDto>();
        }
    }
}
