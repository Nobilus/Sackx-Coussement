using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Project.Models;

namespace Project.DTO
{
    public class ProductAddDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Thickness { get; set; }
        [Required]
        public double Width { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double PurchasePrice { get; set; }
        [Required]
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
        public double PurchasePrice { get; set; }
        [JsonIgnore]
        public Unit Unit { get; set; }
        public string MeasurmentUnit { get; set; }

    }
}


