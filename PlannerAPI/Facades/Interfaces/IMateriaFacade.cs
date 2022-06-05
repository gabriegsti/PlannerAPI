using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data.Dtos.Materia;
using PlannerAPI.Model;
using System.Collections.Generic;

namespace PlannerAPI.Facades.Interfaces
{
    public interface IMateriaFacade
    {
        Materia AdicionaMateria(CreateMateriaDto materia);
        DbSet<Materia> RecuperaMaterias();
        ReadMateriaDto RecuperaMateriaPorId(int id);
        Materia AtualizaMateria(int id, UpdateMateriaDto materiaNova);
        Materia DeletaMateria(int id);
        List<Materia> RecuperaMateriaPorTexto(string texto);
    }
}
