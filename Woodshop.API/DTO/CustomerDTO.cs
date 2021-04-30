using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Project.Models;

namespace Project.DTO
{
    public class CustomerAddDTO
    {
        [Required(ErrorMessage = "Firstname required")]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname required")]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(12)]
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
