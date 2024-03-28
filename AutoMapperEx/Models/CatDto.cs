namespace AutoMapperEx.Models
{
    public class CatDto
    {
        public string Nome { get; set; }
        public DateOnly Nato { get; set; }
        public string Peso { get; set; }
        public string Dimensioni { get; set; }
        public string Tipologia { get; set; }

        public bool Indipendente { get; set; }
    }
}
