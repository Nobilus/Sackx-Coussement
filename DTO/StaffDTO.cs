using System;
using System.Text.Json.Serialization;
using Project.Models;

namespace Project.DTO
{
    public class StaffAddDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
    }
    public class StaffDTO
    {
        [JsonPropertyName("id")]
        public int PersonId { get; set; }
        [JsonIgnore]
        public Person Person { get; set; }
        public string FirstName { get { return Person.FirstName; } }
        public string LastName { get { return Person.LastName; } }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

    }
}
