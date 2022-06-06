using System;

namespace PlannerAPI.Data.Dtos.Materia
{
    public class ReadMateriaDto
    {
        public int Id_Materia { get; set; }
        public string Titulo { get; set; }
        public string Professor { get; set; }
        public DateTime? Data_Inicio { get; set; }
        public DateTime? Data_Fim { get; set; }
    }
}
