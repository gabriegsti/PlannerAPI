using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data;
using PlannerAPI.Data.Dtos.Avaliacao;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Model;
using System.Linq;

namespace PlannerAPI.Facades.Facades
{
    public class AvaliacaoFacade : IAvaliacaoFacade
    {
        private PlannerContext Context { get; set; }
        private IMapper Mapper { get; set; }

        public AvaliacaoFacade(PlannerContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public Avaliacao AdicionaAvaliacao(CreateAvaliacaoDto avaliacaoDto)
        {
            Avaliacao avaliacao = Mapper.Map<Avaliacao>(avaliacaoDto);
            Context.tb_avaliacao.Add(avaliacao);
            Context.SaveChanges();

            return avaliacao;
        }

        public DbSet<Avaliacao> RecuperaAvaliacao()
        {
            return Context.tb_avaliacao;
        }

        public ReadAvaliacaoDto RecuperaAvaliacaoPorId(int id)
        {
            Avaliacao avaliacao = Context.tb_avaliacao.FirstOrDefault(avaliacao => avaliacao.id_avaliacao == id);
            if (avaliacao != null)
            {
                ReadAvaliacaoDto avaliacaoDto = Mapper.Map<ReadAvaliacaoDto>(avaliacao);
                return avaliacaoDto;
            }
            return null;
        }

        public Avaliacao AtualizaAvaliacao(int id, UpdateAvaliacaoDto avaliacaoDto)
        {
            Avaliacao avaliacao = Context.tb_avaliacao.FirstOrDefault(avaliacao => avaliacao.id_avaliacao == id);

            if (avaliacao == null)
                return null;

            Mapper.Map(avaliacaoDto, avaliacao);

            Context.SaveChanges();
            return avaliacao;
        }

        public Avaliacao DeletaAvaliacao(int id)
        {
            Avaliacao avaliacao = Context.tb_avaliacao.FirstOrDefault(avaliacao => avaliacao.Id_Avaliacao == id);
            if (avaliacao == null)
                return null;

            Context.Remove(avaliacao);
            Context.SaveChanges();
            return avaliacao;
        }
    }
}
