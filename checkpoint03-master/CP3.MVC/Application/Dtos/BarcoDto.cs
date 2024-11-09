namespace CP3.MVC.Application.Dtos
{
    public class BarcoDto
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Modelo { get; set; }

        public int Ano { get; set; }

        public double Tamanho { get; set; }
    }
}
