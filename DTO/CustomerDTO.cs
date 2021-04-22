using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Project.Models;

namespace Project.DTO
{
    public class CustomerAddDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyNumber { get; set; }
    }
    public class CustomerDTO
    {
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string CompanyNumber { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
