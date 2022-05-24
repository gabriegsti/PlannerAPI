using System;
using System.ComponentModel.DataAnnotations;

namespace PlannerAPI.Model
{
    public class Materia
    {
        [Key]
        [Required]
        public int Id_Materia { get; set; }
        public int Id_Usuario { get; set; }
        public string Titulo { get; set; }
        public string Email { get; set; }
        public string Professor { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }
    }
}
