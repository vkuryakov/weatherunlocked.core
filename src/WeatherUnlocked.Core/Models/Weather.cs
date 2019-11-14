using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    /// <summary>
    /// Weather data
    /// </summary>
    public class Weather
    {
        private string _iconRepositoryUrl = "http://www.weatherunlocked.com/Images/icons/1/";
        private string _icon = string.Empty;
        /// <summary>
        /// Weather description. List of codes and descriptions: https://developer.weatherunlocked.com/documentation/localweather/resources#descriptions
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Weather code. List of codes and descriptions: https://developer.weatherunlocked.com/documentation/localweather/resources#descriptions
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// Weather icon url. List of icons: https://developer.weatherunlocked.com/documentation/localweather/resources
        /// </summary>
        public string Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                if (!value.StartsWith("http"))
                {
                    _icon = _iconRepositoryUrl + value;
                }
                else
                {
                    _icon = value;
                }
            }
        }
    }
}
