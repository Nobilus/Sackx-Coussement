using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Project.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime Date { get; set; }
        public string OrderType { get; set; }
        public bool IsPayed { get; set; }
        [JsonIgnore]
        public Guid CustomerId { get; set; }
        [JsonIgnore]
        public Customer Customer { get; set; }
        public double InDebted { get; set; }

        [JsonIgnore]
        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}