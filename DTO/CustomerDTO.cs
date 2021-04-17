using System;
using System.Text.Json.Serialization;
using Project.Models;

namespace Project.DTO
{
    public class CustomerDTO
    {
        [JsonPropertyName("id")]
        public int PersonId { get; set; }
        [JsonIgnore]
        public Person Person { get; set; }
        public string FirstName { get { return Person.FirstName; } }
        public string LastName { get { return Person.LastName; } }
        public string CompanyNumber { get; set; }


    }
}
