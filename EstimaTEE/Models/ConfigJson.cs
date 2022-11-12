using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EstimaTEE.Models
{
    public class ConfigJson
    {
        [JsonPropertyName("ConnectionString")]
        public string ConnectionString { get; set; } = string.Empty;
    }
}
