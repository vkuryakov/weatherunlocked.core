using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models.Responses
{
    /// <summary>
    /// Response model for current weather request.
    /// </summary>
    public class CurrentWeatherResponse : LocalWeatherResponse
    {
        /// <summary>
        /// Weather station latitude
        /// </summary>
        public float lat { get; set; }
        /// <summary>
        /// Weather station longitude
        /// </summary>
        public float lon { get; set; }
        /// <summary>
        /// Weather station altitude (meters)
        /// </summary>
        public float alt_m { get; set; }
        /// <summary>
        /// Weather station altitude (feet)
        /// </summary>
        public float alt_ft { get; set; }
    }
}
