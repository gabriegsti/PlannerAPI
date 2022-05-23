using Microsoft.EntityFrameworkCore;
using PlannerAPI.Model;

namespace PlannerAPI.Data
{
    public class UsuarioContext : DbContext
    {

        public UsuarioContext(DbContextOptions<UsuarioContext> opt) : base(opt)
        {

        }

        public DbSet<Usuario> tb_usuario { get; set; }
    }

}
