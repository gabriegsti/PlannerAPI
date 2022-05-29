using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data.Dtos.Avaliacao;
using PlannerAPI.Model;

namespace PlannerAPI.Facades.Interfaces
{
    public interface IAvaliacaoFacade
    {
        Avaliacao AdicionaAvaliacao(CreateAvaliacaoDto avaliacao);
        DbSet<Avaliacao> RecuperaAvaliacao();
        ReadAvaliacaoDto RecuperaAvaliacaoPorId(int id);
        Avaliacao AtualizaAvaliacao(int id, UpdateAvaliacaoDto avaliacaoNova);
        Avaliacao DeletaAvaliacao(int id);
    }
}
