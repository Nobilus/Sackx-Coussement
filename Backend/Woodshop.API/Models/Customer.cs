using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Project.Models
{
    public class Customer
    {
        [JsonIgnore]
        [Key]
        public Guid CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string FirstName { get; set; }

        public string Street { get; set; }

        public int Postal { get; set; }

        public string City { get; set; }

        public string VatNumber { get; set; }

        public ICollection<Order> Orders { get; set; }


    }
}