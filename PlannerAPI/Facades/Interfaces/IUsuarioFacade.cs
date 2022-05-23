using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data.Dtos;
using PlannerAPI.Model;

namespace PlannerAPI.Facades.Interfaces
{
    public interface IUsuarioFacade
    {
        Usuario AdicionaUsuario(CreateUsuarioDto usuario);
        DbSet<Usuario> RecuperaUsuarios();
        ReadUsuarioDto RecuperaUsuarioPorId(int id);
        Usuario AtualizaUsuario(int id, UpdateUsuarioDto usuarioNovo);
        Usuario DeletaUsuario(int id);
    }
}
