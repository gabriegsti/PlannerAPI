using Microsoft.AspNetCore.Mvc;
using PlannerAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace PlannerAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> Usuarios = new List<Usuario>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionaUsuario([FromBody] Usuario usuario)
        {
            usuario.Id = id++;
            Usuarios.Add(usuario);
            return CreatedAtAction(nameof(RecuperaUsuarioPorId), new { Id = usuario.Id }, usuario);
        }

        [HttpGet]
        public IActionResult RecuperaUsuarios()
        {
            return Ok(Usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaUsuarioPorId(int id)
        {
            Usuario usuario =  Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario != null)
              return  Ok(usuario);
            return NotFound();
        }

    }
}
