using Microsoft.AspNetCore.Mvc;
using PlannerAPI.Data.Dtos.Materia;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Models;

namespace PlannerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MateriaController : ControllerBase
    {
        public IMateriaFacade MateriaFacade { get; set; }
        public MateriaController(IMateriaFacade materiaFacade)
        {
            MateriaFacade = materiaFacade;
        }
        [HttpPost]
        public IActionResult AdicionaMateria([FromBody] CreateMateriaDto materiaDto)
        {
            Materia materia = MateriaFacade.AdicionaMateria(materiaDto);
            return CreatedAtAction(nameof(RecuperaMateriaPorId), new { Id = materia }, materia);
        }

        [HttpGet]
        public IActionResult RecuperaMaterias()
        {
            return Ok(MateriaFacade.RecuperaMaterias());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaMateriaPorId(int id)
        {
            ReadMateriaDto materia = MateriaFacade.RecuperaMateriaPorId(id);
            if (materia != null)
                return Ok(materia);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaMateria(int id, [FromBody] UpdateMateriaDto materiaDto)
        {
            Materia materia = MateriaFacade.AtualizaMateria(id, materiaDto);
            if (materia == null)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaMateria(int id)
        {
            Materia materia = MateriaFacade.DeletaMateria(id);
            if (materia == null)
                return NotFound();
            return NoContent();
        }

        [HttpGet("{texto:alpha}")]
        public IActionResult RecuperaMateriaPorTexto([FromQuery] string Texto)
        {
            var materia = MateriaFacade.RecuperaMateriaPorTexto(Texto);
            if (materia != null)
                return Ok(materia);
            return NotFound();
        }

    }

}

