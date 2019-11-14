using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    public class Cloud
    {
        /// <summary>
        /// Amount of low level cloud (percent)
        /// </summary>
        public float LowLevelAmount { get; set; }
        /// <summary>
        /// Amount of mid level cloud (percent)
        /// </summary>
        public float MidLevelAmount { get; set; }
        /// <summary>
        /// Amount of high level cloud (percent)
        /// </summary>
        public float HighLevelAmount { get; set; }
        /// <summary>
        /// Amount of total cloud (percent)
        /// </summary>
        public float Total { get; set; }
    }
}
