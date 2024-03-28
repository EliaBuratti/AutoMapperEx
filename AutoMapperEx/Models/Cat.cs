namespace AutoMapperEx.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly Born { get; set; }
        public string Weight { get; set; }
        public string Dimension { get; set; }
        public string Kind { get; set; }
        public bool Indipendent { get; set; }
    }
}
