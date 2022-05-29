﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlannerAPI.Data.Dtos.Aula;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Model;

namespace PlannerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulaController : ControllerBase
    {
        public IAulaFacade AulaFacade { get; set; }
        public AulaController(IAulaFacade aulaFacade)
        {
            AulaFacade = aulaFacade;
        }
        [HttpPost]
        public IActionResult AdicionaAula([FromBody] CreateAulaDto aulaDto)
        {
            Aula aula = AulaFacade.AdicionaAula(aulaDto);
            return CreatedAtAction(nameof(RecuperaAulaPorId), new { Id = aula }, aula);
        }

        [HttpGet]
        public IActionResult RecuperaAulas()
        {
            return Ok(AulaFacade.RecuperaAulas());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaAulaPorId(int id)
        {
            ReadAulaDto aula = AulaFacade.RecuperaAulaPorId(id);
            if (aula != null)
                return Ok(aula);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaAula(int id, [FromBody] UpdateAulaDto aulaDto)
        {
            Aula aula = AulaFacade.AtualizaAula(id, aulaDto);
            if (aula == null)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaAula(int id)
        {
            Aula aula = AulaFacade.DeletaAula(id);
            if (aula == null)
                return NotFound();
            return NoContent();
        }

    }
}