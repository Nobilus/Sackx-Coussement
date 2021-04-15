using System;
using System.Collections.Generic;

namespace Project.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime Date { get; set; }


        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
