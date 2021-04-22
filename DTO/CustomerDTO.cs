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
        [JsonPropertyName("id")]
        public int PersonId { get; set; }
        [JsonIgnore]
        public Person Person { get; set; }
        public string FirstName { get { return Person.FirstName; } }
        public string LastName { get { return Person.LastName; } }
        public string CompanyNumber { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
