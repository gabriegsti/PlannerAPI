using AutoMapper;
using PlannerAPI.Data.Dtos.Evento;
using PlannerAPI.Models;

namespace PlannerAPI.Profiles
{
    public class EventoProfile : Profile
    {
        public EventoProfile()
        {
            CreateMap<CreateEventoDto, Evento>();
            CreateMap<UpdateEventoDto, Evento>();
            CreateMap<Evento, ReadEventoDto>();
        }
    }
}
