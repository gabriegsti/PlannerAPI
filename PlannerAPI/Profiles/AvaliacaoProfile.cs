using AutoMapper;
using PlannerAPI.Data.Dtos.Avaliacao;
using PlannerAPI.Models;

namespace PlannerAPI.Profiles
{
    public class AvaliacaoProfile : Profile
    {
        public AvaliacaoProfile()
        {
            CreateMap<CreateAvaliacaoDto, Avaliacao>();
            CreateMap<UpdateAvaliacaoDto, Avaliacao>();
            CreateMap<Avaliacao, ReadAvaliacaoDto>();
        }
    }
}
