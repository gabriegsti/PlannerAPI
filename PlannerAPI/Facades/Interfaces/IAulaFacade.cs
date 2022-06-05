using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data.Dtos.Aula;
using PlannerAPI.Model;
using System.Collections.Generic;

namespace PlannerAPI.Facades.Interfaces
{
    public interface IAulaFacade
    {
        Aula AdicionaAula(CreateAulaDto aula);
        DbSet<Aula> RecuperaAula();
        ReadAulaDto RecuperaAulaPorId(int id);
        Aula AtualizaAula(int id, UpdateAulaDto aulaNova);
        Aula DeletaAula(int id);
        List<Aula> RecuperaAulaPorTexto(string texto);
    }
}
