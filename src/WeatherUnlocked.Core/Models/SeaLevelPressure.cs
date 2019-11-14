using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    /// <summary>
    /// Sea level pressure data
    /// </summary>
    public class SeaLevelPressure
    {
        /// <summary>
        /// Sea level pressure (millibars)
        /// </summary>
        public float Millibars { get; set; }
        /// <summary>
        /// Sea level pressure (inches)
        /// </summary>
        public float Inches { get; set; }
    }
}
