using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data.Dtos.Materia;
using PlannerAPI.Model;

namespace PlannerAPI.Facades.Interfaces
{
    public interface IMateriaFacade
    {
        Materia AdicionaMateria(CreateMateriaDto materia);
        DbSet<Materia> RecuperaMaterias();
        ReadMateriaDto RecuperaMateriaPorId(int id);
        Materia AtualizaMateria(int id, UpdateMateriaDto materiaNova);
        Materia DeletaMateria(int id);
    }
}
