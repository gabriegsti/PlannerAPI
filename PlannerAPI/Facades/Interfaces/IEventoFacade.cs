﻿using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data.Dtos.Evento;
using PlannerAPI.Model;

namespace PlannerAPI.Facades.Interfaces
{
    public interface IEventoFacade
    {
        public Evento AdicionaEvento(CreateEventoDto eventoDto);
        public DbSet<Evento> RecuperaEvento();
        public ReadEventoDto RecuperaEventoPorId(int id);
        public Evento AtualizaEvento(int id, UpdateEventoDto eventoNovo);
        public Evento DeletaEvento(int id);
    }
}