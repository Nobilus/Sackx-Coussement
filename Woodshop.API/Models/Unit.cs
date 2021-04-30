using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Project.Models
{
    public class Unit
    {
        public int UnitId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        [JsonIgnore]
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
