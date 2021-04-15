using System;

namespace Project.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Naam { get; set; }
        public double Dikte { get; set; }
        public double Breedte { get; set; }
        public double Lengte { get; set; }
    }
}
