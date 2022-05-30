using System;
using System.ComponentModel.DataAnnotations;

namespace PlannerAPI.Data.Dtos.Evento
{
    public class CreateEventoDto
    {

        [Required(ErrorMessage = "O campo titulo é obrigatório.")]
        public string Titulo { get; set; }
        public DateTime? Data_Hora { get; set; }
        [Required(ErrorMessage = "O campo id_usuario é obrigatório.")]
        public int Id_Usuario { get; set; }
    }
}
