using AutoMapper.Configuration.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    /// <summary>
    /// Temperature data
    /// </summary>
    public class Temperature
    {
        /// <summary>
        /// Temperature (celcius)
        /// </summary>
        public float Celcius { get; set; }
        /// <summary>
        /// Temperature (fahrenheit)
        /// </summary>
        public float Fahrenheit { get; set; }
    }
}
