namespace bebrewery.Models
{
    public class Levedura
    {
        public string Tipo { get; set; }
        public string Estilo { get; set; }
        public double Atenuacao { get; set; } // %
        public double TempIdeal { get; set; }
    }
}