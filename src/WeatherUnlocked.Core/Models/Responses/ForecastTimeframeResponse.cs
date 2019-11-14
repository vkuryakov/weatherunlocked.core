using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherUnlocked.Core.JsonConverters;

namespace WeatherUnlocked.Core.Models.Responses
{
    public class ForecastTimeframeResponse : LocalWeatherResponse
    {
        public DateTime date { get; set; }
        [JsonConverter(typeof(TimeConverter))]
        public TimeSpan time { get; set; }
        public DateTime utcdate { get; set; }
        [JsonConverter(typeof(TimeConverter))]
        public TimeSpan utctime { get; set; }
        /// <summary>
        /// Maximum wind gust (miles per hour)
        /// </summary>
        public float windgst_mph { get; set; }
        /// <summary>
        /// Maximum wind gust (kilometers per hour)
        /// </summary>
        public float windgst_kmh { get; set; }
        /// <summary>
        /// Maximum wind gust (knots)
        /// </summary>
        public float windgst_kts { get; set; }
        /// <summary>
        /// Maximum wind gust (metres per second)
        /// </summary>
        public float windgst_ms { get; set; }
        /// <summary>
        /// Amount of low level cloud (percent)
        /// </summary>
        public float cloud_low_pct { get; set; }
        /// <summary>
        /// Amount of mid level cloud (percent)
        /// </summary>
        public float cloud_mid_pct { get; set; }
        /// <summary>
        /// Amount of high level cloud (percent)
        /// </summary>
        public float cloud_high_pct { get; set; }
        /// <summary>
        /// Amount of precipitation (millimeters)
        /// </summary>
        public float precip_mm { get; set; }
        /// <summary>
        /// Amount of precipitation (inches)
        /// </summary>
        public float precip_in { get; set; }
        /// <summary>
        /// Amount of precipitation falling as rain (millimeters)
        /// </summary>
        public float rain_mm { get; set; }
        /// <summary>
        /// Amount of precipitation falling as rain (inches)
        /// </summary>
        public float rain_in { get; set; }
        /// <summary>
        /// Amount of precipitation falling as snow (millimeters)
        /// </summary>
        public float snow_mm { get; set; }
        /// <summary>
        /// Amount of precipitation falling as snow (inches)
        /// </summary>
        public float snow_in { get; set; }
        /// <summary>
        /// Amount of fresh snowfall - if accumulated (centimetres)
        /// </summary>
        public float snow_accum_cm { get; set; }
        /// <summary>
        /// Amount of fresh snowfall - if accumulated (inches)
        /// </summary>
        public float snow_accum_in { get; set; }
        /// <summary>
        /// Probability of precipitation falling (percent)
        /// </summary>
        public string prob_precip_pct { get; set; }
    }
}
