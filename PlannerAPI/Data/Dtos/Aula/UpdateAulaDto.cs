using System.ComponentModel.DataAnnotations;
using System;
namespace PlannerAPI.Data.Dtos.Aula
{
    public class UpdateAulaDto
    {
        [Required]
        public int id_materia { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório.")]
        public string titulo { get; set; }
        public DateTime data_hora { get; set; }
        public string link { get; set; }
    }
}
