using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models.Responses
{
    public class LocalWeatherResponse
    {
        /// <summary>
        /// Weather description as text. List of codes and descriptions: https://developer.weatherunlocked.com/documentation/localweather/resources#descriptions
        /// </summary>
        public string wx_desc { get; set; }
        /// <summary>
        /// Weather code. List of codes and descriptions: https://developer.weatherunlocked.com/documentation/localweather/resources#descriptions
        /// </summary>
        public int wx_code { get; set; }
        /// <summary>
        /// Weather icon file name. List of icons: https://developer.weatherunlocked.com/documentation/localweather/resources
        /// </summary>
        public string wx_icon { get; set; }
        /// <summary>
        /// Actual temperature in celcius
        /// </summary>
        public float temp_c { get; set; }
        /// <summary>
        /// Actual temperature in fahrenheit
        /// </summary>
        public float temp_f { get; set; }
        /// <summary>
        /// Feel like temperature in celcius
        /// </summary>
        public float feelslike_c { get; set; }
        /// <summary>
        /// Feel like temperature in fahrenheit
        /// </summary>
        public float feelslike_f { get; set; }
        /// <summary>
        /// Wind speed (miles per hour)
        /// </summary>
        public float windspd_mph { get; set; }
        /// <summary>
        /// Wind speed (kilometers per hour)
        /// </summary>
        public float windspd_kmh { get; set; }
        /// <summary>
        /// Wind speed (knots)
        /// </summary>
        public float windspd_kts { get; set; }
        /// <summary>
        /// Wind speed (metres per second)
        /// </summary>
        public float windspd_ms { get; set; }
        /// <summary>
        /// Direction wind is coming from (degrees, 0-360)
        /// </summary>
        public float winddir_deg { get; set; }
        /// <summary>
        /// Direction wind is coming from (16 point)
        /// </summary>
        public string winddir_compass { get; set; }
        /// <summary>
        /// Amount of total cloud (percent)
        /// </summary>
        public float cloudtotal_pct { get; set; }
        /// <summary>
        /// Humidity level (percent)
        /// </summary>
        public float humid_pct { get; set; }
        /// <summary>
        /// Dew point (Celcius)
        /// </summary>
        public float dewpoint_c { get; set; }
        /// <summary>
        /// Dew point (Fahrenheit)
        /// </summary>
        public float dewpoint_f { get; set; }
        /// <summary>
        /// Visibility (kilometers)
        /// </summary>
        public float vis_km { get; set; }
        /// <summary>
        /// Visibility (miles)
        /// </summary>
        public float vis_mi { get; set; }
        /// <summary>
        /// Sea level pressure (millibars)
        /// </summary>
        public float slp_mb { get; set; }
        /// <summary>
        /// Sea level pressure (inches)
        /// </summary>
        public float slp_in { get; set; }
    }
}
