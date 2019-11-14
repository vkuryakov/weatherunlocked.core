using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    /// <summary>
    /// Precipitation data
    /// </summary>
    public class Precipitation
    {
        /// <summary>
        /// Amount of precipitation (millimeters)
        /// </summary>
        public float Millimeters { get; set; }
        /// <summary>
        /// Amount of precipitation (inches)
        /// </summary>
        public float Inches { get; set; }
    }
}
