using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data.Dtos;
using PlannerAPI.Model;
using System.Collections.Generic;

namespace PlannerAPI.Facades.Interfaces
{
    public interface IAnotacaoFacade
    {
        Anotacao AdicionaAnotacao(CreateAnotacaoDto Anotacao);
        DbSet<Anotacao> RecuperaAnotacao();
        ReadAnotacaoDto RecuperaAnotacaoPorId(int id);
        Anotacao AtualizaAnotacao(int id, UpdateAnotacaoDto AnotacaoNova);
        Anotacao DeletaAnotacao(int id);
        List<Anotacao> RecuperaAnotacaoPorTexto(string texto);
    }
}
