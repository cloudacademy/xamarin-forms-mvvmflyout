using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MVVMFlyout.Models
{
    public class Country
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("alpha3Code")]
        public string Alpha3Code { get; set; }

        [JsonPropertyName("numericCode")]
        public string Id { get; set; }

        [JsonIgnore]
        public bool? Independent { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
