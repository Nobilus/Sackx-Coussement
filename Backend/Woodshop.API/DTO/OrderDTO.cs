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
        public Guid CustomerId { get; set; }
        public string OrderType { get; set; }
        public List<OrderAddProductDTO> Products { get; set; }
    }


    public class OrdersDTO
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Firstname { get; set; }
        public string CustomerName { get; set; }
        public string Street { get; set; }
        public int Postal { get; set; }
        public string City { get; set; }
        public double Indebted { get; set; }
        public double VAT { get; set; }
        public string OrderType { get; set; }
        public bool IsPayed { get; set; }
        public ICollection<OrderProductDTO> OrderDetails { get; set; }

    }

    public class OrderPatchDTO
    {
        public bool IsPayed { get; set; }
    }
}
