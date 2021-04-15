using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
