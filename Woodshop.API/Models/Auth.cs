using System;
using Newtonsoft.Json;

namespace Project.Models
{
    public class Auth
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }
        [JsonProperty(PropertyName = "token_type")]
        public string Type { get; set; }

    }
}
