using System;

namespace Project.Models
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
