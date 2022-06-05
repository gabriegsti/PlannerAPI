using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PlannerAPI.Data;
using PlannerAPI.Data.Dtos;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace PlannerAPI.Facades
{
    public class AnotacaoFacade : IAnotacaoFacade
    {
        private PlannerContext Context { get; set; }
        private IMapper Mapper { get; set; }

        public AnotacaoFacade(PlannerContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public Anotacao AdicionaAnotacao(CreateAnotacaoDto anotacaoDto)
        {
            Anotacao anotacao = Mapper.Map<Anotacao>(anotacaoDto);
            Context.tb_anotacao.Add(anotacao);
            Context.SaveChanges();

            return anotacao;
        }

        public DbSet<Anotacao> RecuperaAnotacao()
        {
            return Context.tb_anotacao;
        }

        public ReadAnotacaoDto RecuperaAnotacaoPorId(int id)
        {
            Anotacao anotacao = Context.tb_anotacao.FirstOrDefault(anotacao => anotacao.Id_Anotacao == id);
            if (anotacao != null)
            {
                ReadAnotacaoDto anotacaoDto = Mapper.Map<ReadAnotacaoDto>(anotacao);
                return anotacaoDto;
            }
            return null;
        }

        public Anotacao AtualizaAnotacao(int id, UpdateAnotacaoDto anotacaoDto)
        {
            Anotacao anotacao = Context.tb_anotacao.FirstOrDefault(anotacao => anotacao.Id_Anotacao == id);

            if (anotacao == null)
                return null;

            Mapper.Map(anotacaoDto, anotacao);

            Context.SaveChanges();
            return anotacao;
        }

        public Anotacao DeletaAnotacao(int id)
        {
            Anotacao anotacao = Context.tb_anotacao.FirstOrDefault(Anotacao => Anotacao.Id_Anotacao == id);
            if (anotacao == null)
                return null;

            Context.Remove(anotacao);
            Context.SaveChanges();
            return anotacao;
        }
        public List<Anotacao> RecuperaAnotacaoPorTexto(string texto)
        {
            return Context.tb_anotacao.Where(anotacao => anotacao.Campo_Texto.Contains(texto)).ToList<Anotacao>();
        }
    }
}
