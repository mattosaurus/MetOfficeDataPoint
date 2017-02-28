using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Models
{
    public class Rep3Hourly
    {
        [JsonProperty("D")]
        public string WindDirection { get; set; }

        [JsonProperty("F")]
        public int FeelsLikeTemperature { get; set; }

        [JsonProperty("G")]
        public int WindGust { get; set; }

        [JsonProperty("H")]
        public double ScreenRelativeHumidity { get; set; }

        [JsonProperty("Pp")]
        public int PrecipitationProbability { get; set; }

        [JsonProperty("S")]
        public int WindSpeed { get; set; }

        [JsonProperty("T")]
        public double Temperature { get; set; }

        [JsonProperty("V")]
        public string Visibility { get; set; }

        [JsonProperty("W")]
        public int WeatherType { get; set; }

        [JsonProperty("U")]
        public int MaximumUvIndex { get; set; }

        /// <summary>
        /// The value of a Rep object ($ in the JSON representation) denotes the number of minutes after midnight GMT on the day represented by the Period object in which the Rep object is found
        /// </summary>
        [JsonProperty("$")]
        public int MinutesAfterMidnight { get; set; }
    }
}
