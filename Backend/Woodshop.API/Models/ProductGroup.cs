using System;
using System.Collections.Generic;
using Project.Models;

namespace Woodshop.API.Models
{
    public class ProductGroup
    {
        public int ProductGroupId { get; set; }
        public string ProductGroupName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
