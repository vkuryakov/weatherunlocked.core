using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    /// <summary>
    /// Weather station data
    /// </summary>
    public class Station
    {
        /// <summary>
        /// Weather station latitude
        /// </summary>
        public float Latitude { get; set; }
        /// <summary>
        /// Weather station longitude
        /// </summary>
        public float Longitude { get; set; }
        /// <summary>
        /// Weather station altitude (meters)
        /// </summary>
        public float AltitudeM { get; set; }
        /// <summary>
        /// Weather station altitude (feet)
        /// </summary>
        public float AltitudeF { get; set; }
    }
}
