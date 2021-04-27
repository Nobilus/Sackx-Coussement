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
        public int Id { get; set; }
        [JsonIgnore]
        public Person Person { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

    }
}
