using System.ComponentModel.DataAnnotations;

namespace PlannerAPI.Model
{
    public class Anotacao
    {
        [Key]
        public int Id_Anotacao { get; set; }
        [Required]
        public int Id_Aula { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string Titulo { get; set; }
        public string Campo_Texto { get; set; }

    }
}
