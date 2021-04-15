using System;

namespace Project.Models
{
    public class Staff
    {
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public virtual Person Person { get; set; }
        public int? PersonId { get; set; }
        public bool IsAdmin { get; set; }
    }
}
