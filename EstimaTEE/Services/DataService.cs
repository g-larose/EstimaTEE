using EstimaTEE.Interfaces;
using EstimaTEE.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EstimaTEE.Services
{
    public class DataService : IDataService
    {
        public string GetConnectionString()
        {
            var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configuration", "config.json");
            var fs = new FileStream(jsonPath, FileMode.Open);
            var json = JsonSerializer.Deserialize<ConfigJson>(fs);
            return json.ConnectionString;
        }
    }
}
