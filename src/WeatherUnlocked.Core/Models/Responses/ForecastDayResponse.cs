using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models.Responses
{
    /// <summary>
    /// Response model for "day" entity of the forecast command. More details here:
    /// https://developer.weatherunlocked.com/documentation/localweather/resources#response-fields
    /// </summary>
    public class ForecastDayResponse
    {
        public DateTime date { get; set; }
        /// <summary>
        /// Civil sunrise time
        /// </summary>
        public TimeSpan sunrise_time { get; set; }
        /// <summary>
        /// Civil sunset time
        /// </summary>
        public TimeSpan sunset_time { get; set; }
        /// <summary>
        /// Moonrise time
        /// </summary>
        public TimeSpan moonrise_time { get; set; }
        /// <summary>
        /// Moonset time
        /// </summary>
        public TimeSpan moonset_time { get; set; }
        /// <summary>
        /// Maximum temperature (Celcius)
        /// </summary>
        public float temp_max_c { get; set; }
        /// <summary>
        /// Maximum temperature (Fahrenheit)
        /// </summary>
        public float temp_max_f { get; set; }
        /// <summary>
        /// Minimum temperature (Celcius)
        /// </summary>
        public float temp_min_c { get; set; }
        /// <summary>
        /// Minimum temperature (Fahrenheit)
        /// </summary>
        public float temp_min_f { get; set; }
        /// <summary>
        /// Total amount of precipitation (millimeters)
        /// </summary>
        public float precip_total_mm { get; set; }
        /// <summary>
        /// Total amount of precipitation (inches)
        /// </summary>
        public float precip_total_in { get; set; }
        /// <summary>
        /// Total amount of precipitation falling as rain (millimeters)
        /// </summary>
        public float rain_total_mm { get; set; }
        /// <summary>
        /// Total amount of precipitation falling as rain (inches)
        /// </summary>
        public float rain_total_in { get; set; }
        /// <summary>
        /// Total amount of precipitation falling as snow (millimeters)
        /// </summary>
        public float snow_total_mm { get; set; }
        /// <summary>
        /// total amount of precipitation falling as snow (inches)
        /// </summary>
        public float snow_total_in { get; set; }
        /// <summary>
        /// Probability of precipitation falling (percent)
        /// </summary>
        public float prob_precip_pct { get; set; }
        /// <summary>
        /// Maximum humidity level (percent)
        /// </summary>
        public float humid_max_pct { get; set; }
        /// <summary>
        /// Minimum humidity level (percent)
        /// </summary>
        public float humid_min_pct { get; set; }
        /// <summary>
        /// Maximum mean wind speed (miles per hour)
        /// </summary>
        public float windspd_max_mph { get; set; }
        /// <summary>
        /// Maximum mean wind speed (kilometers per hour)
        /// </summary>
        public float windspd_max_kmh { get; set; }
        /// <summary>
        /// Maximum mean wind speed (knots)
        /// </summary>
        public float windspd_max_kts { get; set; }
        /// <summary>
        /// Maximum mean wind speed (metres per second)
        /// </summary>
        public float windspd_max_ms { get; set; }
        /// <summary>
        /// Maximum wind gust (miles per hour)
        /// </summary>
        public float windgst_max_mph { get; set; }
        /// <summary>
        /// Maximum wind gust (kilometers per hour)
        /// </summary>
        public float windgst_max_kmh { get; set; }
        /// <summary>
        /// Maximum wind gust (knots)
        /// </summary>
        public float windgst_max_kts { get; set; }
        /// <summary>
        /// Maximum wind gust (metres per second)
        /// </summary>
        public float windgst_max_ms { get; set; }
        /// <summary>
        /// Maximum sea level pressure (inches)
        /// </summary>
        public float slp_max_in { get; set; }
        /// <summary>
        /// Maximum sea level pressure (millibars)
        /// </summary>
        public float slp_max_mb { get; set; }
        /// <summary>
        /// Minimum sea level pressure (inches)
        /// </summary>
        public float slp_min_in { get; set; }
        /// <summary>
        /// Minimum sea level pressure (millibars)
        /// </summary>
        public float slp_min_mb { get; set; }
        public ForecastTimeframeResponse[] Timeframes { get; set; }
    }
}
