using System;
using System.ComponentModel.DataAnnotations;

namespace PlannerAPI.Model
{
    public class Evento
    {
        [Key]
        public int id_evento { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório.")]
        public string titulo { get; set; }
        public DateTime? data_hora { get; set; }
    }
}
