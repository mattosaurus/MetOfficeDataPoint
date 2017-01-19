using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Models
{
    public class Location
    {
        [JsonProperty("elevation")]
        public double Elevation { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("unitaryAuthArea")]
        public string UnitaryAuthorityArea { get; set; }
    }
}
