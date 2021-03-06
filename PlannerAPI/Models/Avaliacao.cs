using PlannerAPI.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace PlannerAPI.Models
{
    public class Avaliacao : IAgendavel
    {
        [Key]
        [Required]
        public int Id_Avaliacao { get; set; }
        [Required]
        public int Id_Materia { get; set; }
        [Required(ErrorMessage ="O campo titulo é obrigatório")]
        public string Titulo { get; set; }
        public double? Nota { get; set; }
        public DateTime? Data_Hora { get; set; }
        public int Id_Evento { get; set; }
    }
}
