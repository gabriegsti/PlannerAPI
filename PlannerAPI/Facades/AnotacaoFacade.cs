using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data;
using PlannerAPI.Data.Dtos.Anotacao;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Model;
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
            Anotacao anotacao = Context.tb_anotacao.FirstOrDefault(anotacao => anotacao.id_anotacao == id);
            if (anotacao != null)
            {
                ReadAnotacaoDto anotacaoDto = Mapper.Map<ReadAnotacaoDto>(anotacao);
                return anotacaoDto;
            }
            return null;
        }

        public Anotacao AtualizaAnotacao(int id, UpdateAnotacaoDto AnotacaoDto)
        {
            Anotacao anotacao = Context.tb_anotacao.FirstOrDefault(Anotacao => Anotacao.id_anotacao == id);

            if (anotacao == null)
                return null;

            Mapper.Map(AnotacaoDto, anotacao);

            Context.SaveChanges();
            return anotacao;
        }

        public Anotacao DeletaAnotacao(int id)
        {
            Anotacao anotacao = Context.tb_anotacao.FirstOrDefault(Anotacao => Anotacao.id_anotacao == id);
            if (anotacao == null)
                return null;

            Context.Remove(anotacao);
            Context.SaveChanges();
            return anotacao;
        }
    }
}
