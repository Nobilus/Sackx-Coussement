using System;

namespace Project.Models
{
    public class OrderProduct
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public double Quantity { get; set; }
        public int UnitId { get; set; }
        public bool IsPayed { get; set; }
    }
}
