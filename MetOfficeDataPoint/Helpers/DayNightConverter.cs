using MetOfficeDataPoint.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Helpers
{
    public class DayNightConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(T));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            JToken dayToken;
            JToken nightToken;

            if (token.First().Value<string>("$") == "Day")
            {
                dayToken = token.First();
                nightToken = token.Last();
            }
            else
            {
                dayToken = token.Last();
                nightToken = token.First();
            }

            RepDaily daily = new RepDaily();
            daily.Day = dayToken.ToObject<RepDailyDay>();
            daily.Night = nightToken.ToObject<RepDailyNight>();

            return daily;
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
