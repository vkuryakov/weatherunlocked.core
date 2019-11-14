using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    public class Wind
    {
        /// <summary>
        /// Wind speed
        /// </summary>
        public Speed Speed { get; set; }
        /// <summary>
        /// Direction wind is coming from (degrees, 0-360)
        /// </summary>
        public float DirectionDeg { get; set; }
        /// <summary>
        /// Direction wind is coming from (16 point)
        /// </summary>
        public string DirectionCompass { get; set; }
    }
}
