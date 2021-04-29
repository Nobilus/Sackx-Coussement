using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Project.Models;

namespace Project.DTO
{

    public class OrderAddProductDTO
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
    }
    public class OrderDTO
    {
        public double Amount { get; set; }
        public int CustomerId { get; set; }
        public List<Guid> Products { get; set; }
    }

    public class OrdersDTO
    {
        public Guid Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string CompanyNumber { get; set; }
        public ICollection<ProductDTO> Products { get; set; }
        // public double Indebted { get; set; }
        // public double Amount { get; set; }

    }
}
