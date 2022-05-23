using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data.Dtos.Materia;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Model;

namespace PlannerAPI.Facades
{
    public class MateriaFacade : IMateriaFacade
    {
        public Materia AdicionaMateria(CreateMateriaDto materia)
        {
            throw new System.NotImplementedException();
        }

        public Materia AtualizaMateria(int id, UpdateMateriaDto materiaNova)
        {
            throw new System.NotImplementedException();
        }

        public Materia DeletaMateria(int id)
        {
            throw new System.NotImplementedException();
        }

        public ReadMateriaDto RecuperaMateriaPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public DbSet<Materia> RecuperaMaterias()
        {
            throw new System.NotImplementedException();
        }
    }
}
