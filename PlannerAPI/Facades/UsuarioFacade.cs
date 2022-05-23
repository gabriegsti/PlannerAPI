using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data;
using PlannerAPI.Data.Dtos;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace PlannerAPI.Facades
{
    public class UsuarioFacade : IUsuarioFacade
    {
        private UsuarioContext Context { get; set; }
        private IMapper Mapper { get; set; }

        public UsuarioFacade(UsuarioContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public Usuario AdicionaUsuario(CreateUsuarioDto usuarioDto)
        {
            Usuario usuario = Mapper.Map<Usuario>(usuarioDto);
            var valor = Context.tb_usuario.Count();
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
