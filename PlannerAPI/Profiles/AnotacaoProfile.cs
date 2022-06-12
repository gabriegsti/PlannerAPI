using AutoMapper;
using PlannerAPI.Data.Dtos;
using PlannerAPI.Models;

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
