using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    /// <summary>
    /// Visibility data
    /// </summary>
    public class Visibility
    {
        /// <summary>
        /// Visibility (kilometers)
        /// </summary>
        public float Kilometers { get; set; }
        /// <summary>
        /// Visibility (miles)
        /// </summary>
        public float Miles { get; set; }
    }
}
