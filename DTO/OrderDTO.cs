using System;
using System.Collections.Generic;

namespace Project.DTO
{
    public class OrderDTO
    {
        public double Amount { get; set; }
        public int CustomerId { get; set; }
        public List<Guid> Products { get; set; }


    }
}
