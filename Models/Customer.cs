using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Project.Models
{
    public class Customer
    {
        public string CompanyNumber { get; set; }
        public virtual Person Person { get; set; }
        public int? PersonId { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
