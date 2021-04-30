using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Project.Models;

namespace Project.DTO
{
    public class StaffAddDTO
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        [Phone]
        public string Telephonenumber { get; set; }
        [EmailAddress]
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
