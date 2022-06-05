using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlannerAPI.Data.Dtos;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Model;
using System.Text.Json;

namespace PlannerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnotacaoController : ControllerBase
    {
        public IAnotacaoFacade AnotacaoFacade { get; set; }
        public AnotacaoController(IAnotacaoFacade anotacaoFacade)
        {
            AnotacaoFacade = anotacaoFacade;
        }
        [HttpPost]
        public IActionResult AdicionaAnotacao([FromBody] CreateAnotacaoDto anotacaoDto)
        {
            Anotacao anotacao = AnotacaoFacade.AdicionaAnotacao(anotacaoDto);
            return CreatedAtAction(nameof(RecuperaAnotacaoPorId), new { Id = anotacao }, anotacao);
        }

        [HttpGet]
        public IActionResult RecuperaAnotacaos()
        {
            return Ok(AnotacaoFacade.RecuperaAnotacao());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaAnotacaoPorId(int id)
        {
            ReadAnotacaoDto anotacao = AnotacaoFacade.RecuperaAnotacaoPorId(id);
            if (anotacao != null)
                return Ok(anotacao);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaAnotacao(int id, [FromBody] UpdateAnotacaoDto anotacaoDto)
        {
            Anotacao anotacao = AnotacaoFacade.AtualizaAnotacao(id, anotacaoDto);
            if (anotacao == null)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaAnotacao(int id)
        {
            Anotacao anotacao = AnotacaoFacade.DeletaAnotacao(id);
            if (anotacao == null)
                return NotFound();
            return NoContent();
        }

        [HttpGet("{texto:alpha}")]
        public IActionResult RecuperaAnotacaoPorTexto([FromQuery] string Texto)
        {
            var anotacoes = AnotacaoFacade.RecuperaAnotacaoPorTexto(Texto);
            if (anotacoes != null)
                return Ok(anotacoes);
            return NotFound();
        }
    }
}
