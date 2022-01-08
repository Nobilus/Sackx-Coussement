using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Project.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public double Thickness { get; set; }
        public double Width { get; set; }
        public double Price { get; set; }
        public double PurchasePrice { get; set; }

        [JsonIgnore]
        public int UnitId { get; set; }
        public Unit Unit { get; set; }

        [JsonIgnore]
        public IList<OrderProduct> OrderProducts { get; set; }

    }
}
