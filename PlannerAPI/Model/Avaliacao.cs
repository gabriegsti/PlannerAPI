using System;
using System.ComponentModel.DataAnnotations;

namespace PlannerAPI.Model
{
    public class Avaliacao : Evento
    {
        [Key]
        [Required]
        public int id_avaliacao { get; set; }
        [Required]
        public int id_materia { get; set; }
    }
}
