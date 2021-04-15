using System;
using System.Collections.Generic;

namespace Project.Models
{
    public class Customer
    {
        public string CompanyNumber { get; set; }
        public virtual Person Person { get; set; }
        public int? PersonId { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

    }
}
