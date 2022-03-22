using System.Text.Json.Serialization;

namespace MetOfficeDataPoint.Models
{
    public class Rep3Hourly
    {
        [JsonPropertyName("D")]
        public string WindDirection { get; set; }

        [JsonPropertyName("F")]
        public int FeelsLikeTemperature { get; set; }

        [JsonPropertyName("G")]
        public int WindGust { get; set; }

        [JsonPropertyName("H")]
        public double ScreenRelativeHumidity { get; set; }

        [JsonPropertyName("Pp")]
        public int PrecipitationProbability { get; set; }

        [JsonPropertyName("S")]
        public int WindSpeed { get; set; }

        [JsonPropertyName("T")]
        public double Temperature { get; set; }

        [JsonPropertyName("V")]
        public string Visibility { get; set; }

        [JsonPropertyName("W")]
        public int WeatherType { get; set; }

        [JsonPropertyName("U")]
        public int MaximumUvIndex { get; set; }

        /// <summary>
        /// The value of a Rep object ($ in the JSON representation) denotes the number of minutes after midnight GMT on the day represented by the Period object in which the Rep object is found
        /// </summary>
        [JsonPropertyName("$")]
        public int MinutesAfterMidnight { get; set; }
    }
}