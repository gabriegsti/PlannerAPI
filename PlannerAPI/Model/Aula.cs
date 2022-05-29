using PlannerAPI.Facades.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace PlannerAPI.Model
{
    public class Aula
    {
        [Key]
        [Required]
        public int id_aula { get; set; }
        [Required]
        public int id_materia { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório.")]
        public string titulo { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório.")]
        public string data_hora { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório.")]
        public DateTime? data { get; set; }
    }
}
