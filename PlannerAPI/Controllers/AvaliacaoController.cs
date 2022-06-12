using Microsoft.AspNetCore.Mvc;
using PlannerAPI.Data.Dtos.Avaliacao;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Models;

namespace PlannerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoController : ControllerBase
    {
        public IAvaliacaoFacade AvaliacaoFacade { get; set; }
        public AvaliacaoController(IAvaliacaoFacade avaliacaoFacade)
        {
            AvaliacaoFacade = avaliacaoFacade;
        }
        [HttpPost]
        public IActionResult AdicionaAvaliacao([FromBody] CreateAvaliacaoDto avaliacaoDto)
        {
            Avaliacao avaliacao = AvaliacaoFacade.AdicionaAvaliacao(avaliacaoDto);
            return CreatedAtAction(nameof(RecuperaAvaliacaoPorId), new { Id = avaliacao }, avaliacao);
        }

        [HttpGet]
        public IActionResult RecuperaAvaliacao()
        {
            return Ok(AvaliacaoFacade.RecuperaAvaliacao());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaAvaliacaoPorId(int id)
        {
            ReadAvaliacaoDto avaliacao = AvaliacaoFacade.RecuperaAvaliacaoPorId(id);
            if (avaliacao != null)
                return Ok(avaliacao);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaAvaliacao(int id, [FromBody] UpdateAvaliacaoDto avaliacaoDto)
        {
            Avaliacao avaliacao = AvaliacaoFacade.AtualizaAvaliacao(id, avaliacaoDto);
            if (avaliacao == null)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaAvaliacao(int id)
        {
            Avaliacao avaliacao = AvaliacaoFacade.DeletaAvaliacao(id);
            if (avaliacao == null)
                return NotFound();
            return NoContent();
        }

    }
}
