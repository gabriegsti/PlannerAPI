using System.ComponentModel.DataAnnotations;

namespace PlannerAPI.Model
{
    public class Anotacao
    {
        [Key]
        [Required]
        public int id_anotacao { get; set; }
        [Required]
        public int id_aula { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string titulo { get; set; }
        public string campo_texto { get; set; }

    }
}
