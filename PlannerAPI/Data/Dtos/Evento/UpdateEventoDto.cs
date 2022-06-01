using System;

namespace PlannerAPI.Data.Dtos.Evento
{
    public class UpdateEventoDto
    {
        public int Id_Evento { get; set; }
        public string Titulo { get; set; }
        public DateTime? Data_Hora { get; set; }
        public int Id_Usuario { get; set; }

    }
}
