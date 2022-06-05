using System;
using System.ComponentModel.DataAnnotations;

namespace PlannerAPI.Model
{
    public class Aula
    {
        [Key]
        [Required]
        public int id_Aula { get; set; }
        [Required]
        public int id_materia { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório.")]
        public string titulo { get; set; }
        public DateTime data_hora { get; set; }
        public string link { get; set; }
    }
}
