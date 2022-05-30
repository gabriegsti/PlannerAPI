using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data;
using PlannerAPI.Data.Dtos.Evento;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Model;
using System.Linq;

namespace PlannerAPI.Facades
{
    public class EventoFacade : IEventoFacade
    {
        private PlannerContext Context { get; set; }
        private IMapper Mapper { get; set; }

        public EventoFacade(PlannerContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public Evento AdicionaEvento(CreateEventoDto eventoDto)
        {
            Evento evento = Mapper.Map<Evento>(eventoDto);
            Context.tb_evento.Add(evento);
            Context.SaveChanges();

            return evento;
        }

        public DbSet<Evento> RecuperaEvento()
        {
            return Context.tb_evento;
        }

        public ReadEventoDto RecuperaEventoPorId(int id)
        {
            Evento evento = Context.tb_evento.FirstOrDefault(evento => evento.Id_Evento == id);
            if (evento != null)
            {
                ReadEventoDto eventoDto = Mapper.Map<ReadEventoDto>(evento);
                return eventoDto;
            }
            return null;
        }

        public Evento AtualizaEvento(int id, UpdateEventoDto eventoNovo)
        {
            Evento evento = Context.tb_evento.FirstOrDefault(evento => evento.Id_Evento == id);

            if (evento == null)
                return null;

            Mapper.Map(eventoNovo, evento);

            Context.SaveChanges();
            return evento;
        }

        public Evento DeletaEvento(int id)
        {
            Evento evento = Context.tb_evento.FirstOrDefault(evento => evento.Id_Evento == id);
            if (evento == null)
                return null;

            Context.Remove(evento);
            Context.SaveChanges();
            return evento;
        }
    }
}
