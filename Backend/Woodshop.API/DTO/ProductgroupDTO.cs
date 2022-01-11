using System;
using System.Collections.Generic;
using Project.DTO;

namespace Woodshop.API.DTO
{
    public class ProductgroupDTO
    {
        public int ProductGroupId { get; set; }
        public string ProductGroupName { get; set; }
        public ICollection<ProductDTO> Products { get; set; }
    }
}
