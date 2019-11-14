using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    public class LocalWeatherData
    {
        /// <summary>
        /// Weather data
        /// </summary>
        public Weather Weather { get; set; }
        /// <summary>
        /// Temperature data
        /// </summary>
        public Temperature Temperature { get; set; }
        /// <summary>
        /// Feels like temperature data
        /// </summary>
        public Temperature FeelsLikeTemperature { get; set; }
        /// <summary>
        /// Humidity level (percent)
        /// </summary>
        public float Humidity { get; set; }
        /// <summary>
        /// DewPoint data
        /// </summary>
        public Temperature DewPoint { get; set; }
        /// <summary>
        /// Visibility data
        /// </summary>
        public Visibility Visibility { get; set; }
        /// <summary>
        /// Sea level pressure data
        /// </summary>
        public SeaLevelPressure Pressure { get; set; }
    }
}
