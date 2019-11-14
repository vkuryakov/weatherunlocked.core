using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherUnlocked.Core.JsonConverters;

namespace WeatherUnlocked.Core.Models
{
    public class ForecastWeatherTimeframe : LocalWeatherData
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime UtcDate { get; set; }
        public TimeSpan UtcTime { get; set; }
        public WindFullInfo Wind { get; set; }
        public Cloud Cloud { get; set; }
        public Precipitation Precipitation { get; set; }
        public Precipitation Rain { get; set; }
        public Precipitation Snow { get; set; }
        public Snowfall Snowfall { get; set; }
        public string PrecipitationProbability { get; set; }
    }
}
