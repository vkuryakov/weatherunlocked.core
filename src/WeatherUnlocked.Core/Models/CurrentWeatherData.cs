using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    public class CurrentWeatherData : LocalWeatherData
    {
        /// <summary>
        /// Station data
        /// </summary>
        public Station Station { get; set; }
        /// <summary>
        /// Cloud data
        /// </summary>
        public float CloudTotal { get; set; }
        /// <summary>
        /// Wind data
        /// </summary>
        public Wind Wind { get; set; }
    }
}
