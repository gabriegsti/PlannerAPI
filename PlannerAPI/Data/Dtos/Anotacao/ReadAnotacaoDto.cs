namespace PlannerAPI.Data.Dtos
{
    public class ReadAnotacaoDto
    {
        public int Id_Anotacao { get; set; }
        public int Id_Aula { get; set; }
        public string Titulo { get; set; }
        public string Campo_Texto { get; set; }
    }
}
