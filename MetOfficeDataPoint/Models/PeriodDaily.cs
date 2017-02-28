using MetOfficeDataPoint.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Models
{
    public class PeriodDaily
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("Rep")]
        [JsonConverter(typeof(DayNightConverter<RepDaily>))]
        public RepDaily Rep { get; set; }
    }
}
