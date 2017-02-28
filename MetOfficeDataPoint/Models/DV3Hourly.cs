using MetOfficeDataPoint.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Models
{
    public class DV3Hourly
    {
        [JsonProperty("dataDate")]
        public string DataDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("Location")]
        [JsonConverter(typeof(SingleOrArrayConverter<ForecastLocation3Hourly>))]
        public List<ForecastLocation3Hourly> Location { get; set; }
    }
}
