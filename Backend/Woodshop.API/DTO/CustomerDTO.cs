using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Project.Models;

namespace Project.DTO
{
    public class CustomerAddDTO
    {
        public string CustomerName { get; set; }
        public string Street { get; set; }
        public int? Postal { get; set; }
        public string City { get; set; }
        public string VatNumber { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string Contact3 { get; set; }
        public string Fax { get; set; }
        public string Telephone { get; set; }

    }
    public class CustomerDTO
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Street { get; set; }
        public int Postal { get; set; }
        public string City { get; set; }
        public string VatNumber { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string Contact3 { get; set; }
        public string Fax { get; set; }
        public string Telephone { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
