using System;
using System.Text.Json.Serialization;
using Project.Models;

namespace Project.DTO
{
    public class ProductAddDTO
    {
        public string Name { get; set; }
        public double Thickness { get; set; }
        public double Width { get; set; }
        public double Price { get; set; }
        public int UnitId { get; set; }
    }
    public class ProductDTO
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public double Thickness { get; set; }
        public double Width { get; set; }
        public double Price { get; set; }
        public double PriceWithVat { get; set; }
        [JsonIgnore]
        public Unit Unit { get; set; }

        [JsonPropertyName("measurement_unit")]
        public string MeasurmentUnit { get { return Unit.Name; } }

    }
}


