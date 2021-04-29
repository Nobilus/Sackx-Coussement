using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Project.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime Date { get; set; }
        // public double Amount { get; set; }
        [JsonIgnore]
        public int CustomerId { get; set; }
        [JsonIgnore]
        public Customer Customer { get; set; }
        [JsonIgnore]
        public IList<OrderProduct> OrderProducts { get; set; }
        // public bool IsPayed { get; set; }
        // public double Amount { get; set; }

    }
}