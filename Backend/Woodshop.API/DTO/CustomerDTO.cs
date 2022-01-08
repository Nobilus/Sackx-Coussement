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
        [MaxLength(50)]
        public string CustomerName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int Postal { get; set; }
        [Required]
        public string City { get; set; }

    }
    public class CustomerDTO
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string FirstName { get; set; }
        public string Street { get; set; }
        public int Postal { get; set; }
        public string City { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
