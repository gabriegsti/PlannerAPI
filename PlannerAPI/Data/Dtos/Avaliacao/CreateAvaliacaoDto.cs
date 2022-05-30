using System;
using System.ComponentModel.DataAnnotations;

namespace PlannerAPI.Data.Dtos.Avaliacao
{
    public class CreateAvaliacaoDto
    {
        [Required]
        public int Id_Materia { get; set; }
        [Required]
        public string Titulo { get; set; }
        public DateTime Data_Hora { get; set; }
        [Required]
        public int Id_Evento { get; set; }
    }
}
