using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    public class Snowfall
    {
        /// <summary>
        /// Amount of fresh snowfall - if accumulated (centimetres)
        /// </summary>
        public float Centimetres { get; set; }
        /// <summary>
        /// Amount of fresh snowfall - if accumulated (inches)
        /// </summary>
        public float Inches { get; set; }
    }
}
