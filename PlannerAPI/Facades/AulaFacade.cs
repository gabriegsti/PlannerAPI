using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data;
using PlannerAPI.Data.Dtos.Aula;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace PlannerAPI.Facades
{
    public class AulaFacade : IAulaFacade
    {
        private PlannerContext Context { get; set; }
        private IMapper Mapper { get; set; }

        public AulaFacade(PlannerContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public Aula AdicionaAula(CreateAulaDto aulaDto)
        {
            Aula aula = Mapper.Map<Aula>(aulaDto);
            Context.tb_aula.Add(aula);
            Context.SaveChanges();
            return aula;
        }

        public DbSet<Aula> RecuperaAula()
        {
            return Context.tb_aula;
        }

        public ReadAulaDto RecuperaAulaPorId(int id)
        {
            Aula aula = Context.tb_aula.FirstOrDefault(aula => aula.id_Aula == id);
            if (aula != null)
            {
                ReadAulaDto aulaDto = Mapper.Map<ReadAulaDto>(aula);
                return aulaDto;
            }
            return null;
        }

        public Aula AtualizaAula(int id, UpdateAulaDto aulaDto)
        {
            Aula aula = Context.tb_aula.FirstOrDefault(aula => aula.id_Aula == id);

            if (aula == null)
                return null;

            Mapper.Map(aulaDto, aula);

            Context.SaveChanges();
            return aula;
        }

        public Aula DeletaAula(int id)
        {
            Aula aula = Context.tb_aula.FirstOrDefault(aula => aula.id_Aula == id);
            if (aula == null)
                return null;

            Context.Remove(aula);
            Context.SaveChanges();
            return aula;
        }

        public List<Aula> RecuperaAulaPorTexto(string texto)
        {
            return Context.tb_aula.Where(aula => aula.titulo.ToLower().Contains(texto.ToLower())).ToList<Aula>();
        }
    }
}
