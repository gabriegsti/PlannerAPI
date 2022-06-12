using PlannerAPI.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace PlannerAPI.Models
{
    public class Evento : IAgendavel
    {
        [Key]
        public int Id_Evento { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório.")]
        public string Titulo { get; set; }
        public DateTime? Data_Hora { get; set; }
        public int Id_Usuario { get; set; }

        public Evento()
        {

        }
        public Evento(string titulo, DateTime? data_hora, int id_usuario )
        {
            Titulo = titulo;
            Data_Hora = data_hora;  
            Id_Usuario = id_usuario; 
        }
    }
}
