using System;
using Newtonsoft.Json;

namespace Woodshop.API.Models
{
    public class APICustomer
    {
        public bool Valid { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string VatNumber { get; set; }

        public APICustomerAddress Address { get; set; }
    }

    public class APICustomerAddress
    {
        public string Street { get; set; }
        public double Number { get; set; }
        [JsonProperty(PropertyName = "zip_code")]
        public double Postal { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
