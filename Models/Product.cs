using System;

namespace Project.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public double Thickness { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Prijs_Excl_Tax { get; set; }
        public double Prijs_Incl_Tax { get; set; }
    }
}
