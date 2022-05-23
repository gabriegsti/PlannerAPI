using Microsoft.EntityFrameworkCore;
using PlannerAPI.Model;

namespace PlannerAPI.Data
{
    public class MateriaContext : DbContext
    {
        public MateriaContext(DbContextOptions<MateriaContext> opt) : base(opt)
        {

        }

        public DbSet<Materia> Tb_Materia { get; set; }
    }
}
