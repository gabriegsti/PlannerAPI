using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data;
using PlannerAPI.Data.Dtos.Usuario;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Models;
using System.Linq;

namespace PlannerAPI.Facades
{
    public class UsuarioFacade : IUsuarioFacade
    {
        private PlannerContext Context { get; set; }
        private IMapper Mapper { get; set; }

        public UsuarioFacade(PlannerContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public Usuario AdicionaUsuario(CreateUsuarioDto usuarioDto)
        {
            Usuario usuario = Mapper.Map<Usuario>(usuarioDto);
            Context.tb_usuario.Add(usuario);
            Context.SaveChanges();

            return usuario;
        }

        public DbSet<Usuario> RecuperaUsuarios()
        {
            return Context.tb_usuario;
        }

        public ReadUsuarioDto RecuperaUsuarioPorId(int id)
        {
            Usuario usuario = Context.tb_usuario.FirstOrDefault(usuario => usuario.Id_Usuario == id);
            if(usuario != null)
            {
                ReadUsuarioDto usuarioDto = Mapper.Map<ReadUsuarioDto>(usuario);   
                return usuarioDto;
            }
            return null;
        }

        public Usuario AtualizaUsuario(int id, UpdateUsuarioDto usuarioDto)
        {
            Usuario usuario = Context.tb_usuario.FirstOrDefault(usuario => usuario.Id_Usuario == id);
           
            if (usuario == null)
                return null;

           Mapper.Map(usuarioDto,usuario);

            Context.SaveChanges();
            return usuario;
        }

        public Usuario DeletaUsuario(int id)
        {
            Usuario usuario = Context.tb_usuario.FirstOrDefault(usuario => usuario.Id_Usuario == id);
            if (usuario == null)
                return null;

            Context.Remove(usuario);
            Context.SaveChanges();
            return usuario;
        }
    }
}
