using MetOfficeDataPoint.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Models
{
    public class DVDaily
    {
        [JsonPropertyName("dataDate")]
        public string DataDate { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("Location")]
        [JsonConverter(typeof(SingleOrArrayConverter<ForecastLocationDaily>))]
        public List<ForecastLocationDaily> Location { get; set; }
    }
}