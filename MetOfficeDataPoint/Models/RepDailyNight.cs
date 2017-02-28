using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Models
{
    public class RepDailyNight
    {
        [JsonProperty("D")]
        public string WindDirection { get; set; }

        [JsonProperty("Gm")]
        public int WindGustMidnight { get; set; }

        [JsonProperty("Hm")]
        public int ScreenRelativeHumidityMidnight { get; set; }

        [JsonProperty("PPn")]
        public int PrecipitationProbabilityNight { get; set; }

        [JsonProperty("S")]
        public int WindSpeed { get; set; }

        [JsonProperty("V")]
        public string Visibility { get; set; }

        [JsonProperty("Nm")]
        public int NightMaximumTemperature { get; set; }

        [JsonProperty("FNm")]
        public int FeelsLikeNightMaximumTemperature { get; set; }

        [JsonProperty("W")]
        public int WeatherType { get; set; }

        [JsonProperty("$")]
        public string Type { get; set; }
    }
}
