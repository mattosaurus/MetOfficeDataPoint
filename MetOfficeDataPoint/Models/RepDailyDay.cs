using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Models
{
    public class RepDailyDay
    {
        [JsonProperty("D")]
        public string WindDirection { get; set; }

        [JsonProperty("Gn")]
        public int WindGustNoon { get; set; }

        [JsonProperty("Hn")]
        public int ScreenRelativeHumidityNoon { get; set; }

        [JsonProperty("PPd")]
        public int PrecipitationProbabilityDay { get; set; }

        [JsonProperty("S")]
        public int WindSpeed { get; set; }

        [JsonProperty("V")]
        public string Visibility { get; set; }

        [JsonProperty("Dm")]
        public int DayMaximumTemperature { get; set; }

        [JsonProperty("FDm")]
        public int FeelsLikeDayMaximumTemperature { get; set; }

        [JsonProperty("W")]
        public int WeatherType { get; set; }

        [JsonProperty("U")]
        public int MaxUVIndex { get; set; }

        [JsonProperty("$")]
        public string Type { get; set; }
    }
}
