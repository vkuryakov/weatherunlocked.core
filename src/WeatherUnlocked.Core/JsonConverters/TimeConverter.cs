using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.JsonConverters
{
    /// <summary>
    /// WeatherUnlocked sends time for the "time" and "utctime" params as int (e.g., 400 in response means 4:00).
    /// That's why we should convert int to TimeStamp.
    /// </summary>
    public class TimeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(TimeSpan)); ;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return string.Empty;
            }
            string value = reader.Value.ToString();
            string time = value;
            // Checking containing ":" in string for the case if WeatherUnlocked will change int format (e.g., 400) to 
            // time format (e.g., 4:00)
            if (!value.Contains(":") && value.Length > 2)
            {
                string hours = value.Substring(0, value.Length - 2);
                string minutes = value.Substring(value.Length - 2);
                time = hours + ":" + minutes;
            }
            TimeSpan result;
            try
            {
                result = TimeSpan.Parse(time);
            }
            catch (Exception e)
            {
                string errorMessage = string.Format("Error converting value {0} to type '{1}'.Path '{2}',line {3}, position {4}.",
                    value,
                    objectType.FullName,
                    reader.Path,
                    (reader as JsonTextReader).LineNumber,
                    (reader as JsonTextReader).LinePosition);
                JsonSerializationException ex = new JsonSerializationException(errorMessage, e);
                throw ex;
            }
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
