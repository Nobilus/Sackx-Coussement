using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Project.Models
{
    public class Customer
    {
        [JsonIgnore]
        [Key]
        public int PersonId { get; set; }

        public string CompanyNumber { get; set; }
        public virtual Person Person { get; set; }


        public ICollection<Order> Orders { get; set; }


    }
}