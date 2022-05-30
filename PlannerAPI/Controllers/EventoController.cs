using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlannerAPI.Data.Dtos.Evento;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Model;

namespace PlannerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        public IEventoFacade EventoFacade { get; set; }
        public EventoController(IEventoFacade eventoFacade)
        {
            EventoFacade = eventoFacade;
        }
        [HttpPost]
        public IActionResult AdicionaEvento([FromBody] CreateEventoDto eventoDto)
        {
            Evento evento = EventoFacade.AdicionaEvento(eventoDto);
            return CreatedAtAction(nameof(RecuperaEventoPorId), new { Id = evento }, evento);
        }

        [HttpGet]
        public IActionResult RecuperaEvento()
        {
            return Ok(EventoFacade.RecuperaEvento());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEventoPorId(int id)
        {
            ReadEventoDto Evento = EventoFacade.RecuperaEventoPorId(id);
            if (Evento != null)
                return Ok(Evento);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEvento(int id, [FromBody] UpdateEventoDto eventoDto)
        {
            Evento evento = EventoFacade.AtualizaEvento(id, eventoDto);
            if (evento == null)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaEvento(int id)
        {
            Evento evento = EventoFacade.DeletaEvento(id);
            if (evento == null)
                return NotFound();
            return NoContent();
        }
    }
}
