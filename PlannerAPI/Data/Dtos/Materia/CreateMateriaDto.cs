using System;

namespace PlannerAPI.Data.Dtos.Materia
{
    public class CreateMateriaDto
    {
        public int Id_Usuario { get; set; }
        public string Titulo { get; set; }
        public string Professor { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }
    }
}
