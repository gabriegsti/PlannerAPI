using Microsoft.EntityFrameworkCore;
using PlannerAPI.Model;

namespace PlannerAPI.Data
{
    public class PlannerContext : DbContext
    {

        public PlannerContext(DbContextOptions<PlannerContext> opt) : base(opt)
        {

        }

        public DbSet<Usuario> tb_usuario { get; set; }
        public DbSet<Materia> tb_materia { get; set; }
    }

}
