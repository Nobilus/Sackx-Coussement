using System;
using System.Collections.Generic;
using Project.DTO;
using Project.Models;

namespace Woodshop.API.DTO
{
    public class BestelbonDTO
    {
        public string CustomerName { get; set; }
        public List<Order> Orders { get; set; }
    }
}
