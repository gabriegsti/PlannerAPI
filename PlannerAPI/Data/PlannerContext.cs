using Microsoft.EntityFrameworkCore;
using PlannerAPI.Model;

namespace PlannerAPI.Data
{
    public class PlannerContext : DbContext
    {

        public PlannerContext(DbContextOptions<PlannerContext> opt) : base(opt)
        {

        }

        public DbSet<Anotacao> tb_anotacao { get; set; }
        public DbSet<Aula> tb_aula { get; set; }
        public DbSet<Avaliacao> tb_avaliacao { get; set; }

        public DbSet<Evento> tb_evento { get; set; }
        public DbSet<Materia> tb_materia { get; set; }
        public DbSet<Usuario> tb_usuario { get; set; }

    }

}
