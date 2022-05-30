using System;

namespace PlannerAPI.Interfaces
{
    public interface IAgendavel
    {
        public string Titulo { get; set; }
        public DateTime? Data_Hora { get; set; }
    }
}
