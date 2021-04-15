using System;
using System.Collections.Generic;

namespace Project.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public double Thickness { get; set; }
        public double Width { get; set; }
        public double Price { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
