using System;
using System.Collections.Generic;

namespace Project.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public IList<OrderProduct> OrderProducts { get; set; }

    }
}
