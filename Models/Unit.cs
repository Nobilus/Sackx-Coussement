using System;
using System.Collections.Generic;

namespace Project.Models
{
    public class Unit
    {
        public Guid UnitId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
