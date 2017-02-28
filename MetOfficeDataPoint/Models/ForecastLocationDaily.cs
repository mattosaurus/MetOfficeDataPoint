using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetOfficeDataPoint.Helpers;

namespace MetOfficeDataPoint.Models
{
    public class ForecastLocationDaily
    {
        [JsonProperty("i")]
        public int LocationId { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lon")]
        public double Longitude { get; set; }

        [JsonProperty("name")]
        public string LocationName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("elevation")]
        public double Elevation { get; set; }

        [JsonProperty("Period")]
        public List<PeriodDaily> Period { get; set; }
    }
}
