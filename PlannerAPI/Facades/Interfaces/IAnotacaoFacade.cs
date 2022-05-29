using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data.Dtos.Anotacao;
using PlannerAPI.Model;

namespace PlannerAPI.Facades.Interfaces
{
    public interface IAnotacaoFacade
    {
        Anotacao AdicionaAnotacao(CreateAnotacaoDto Anotacao);
        DbSet<Anotacao> RecuperaAnotacao();
        ReadAnotacaoDto RecuperaAnotacaoPorId(int id);
        Anotacao AtualizaAnotacao(int id, UpdateAnotacaoDto AnotacaoNova);
        Anotacao DeletaAnotacao(int id);
    }
}
