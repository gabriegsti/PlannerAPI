using Microsoft.AspNetCore.Mvc;
using PlannerAPI.Data;
using PlannerAPI.Data.Dtos;
using PlannerAPI.Data.Dtos.Usuario;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace PlannerAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        public IUsuarioFacade UsuarioFacade { get; set; }
        public UsuarioController(IUsuarioFacade usuarioFacade)
        {
            UsuarioFacade = usuarioFacade;
        }
        [HttpPost]
        public IActionResult AdicionaUsuario([FromBody] CreateUsuarioDto usuarioDto)
        {
            Usuario usuario = UsuarioFacade.AdicionaUsuario(usuarioDto);
            return CreatedAtAction(nameof(RecuperaUsuarioPorId), new { Id = usuario }, usuario);
        }

        [HttpGet]
        public IActionResult RecuperaUsuarios()
        {
            return Ok(UsuarioFacade.RecuperaUsuarios());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaUsuarioPorId(int id)
        {
            ReadUsuarioDto usuario = UsuarioFacade.RecuperaUsuarioPorId(id);
            if (usuario != null)
                return Ok(usuario);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaUsuario(int id, [FromBody] UpdateUsuarioDto usuarioDto)
        {
            Usuario usuario = UsuarioFacade.AtualizaUsuario(id, usuarioDto);
            if(usuario == null)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaUsuario(int id)
        {
            Usuario usuario = UsuarioFacade.DeletaUsuario(id);
            if (usuario == null)
                return NotFound();
            return NoContent();
        }

    }
}
