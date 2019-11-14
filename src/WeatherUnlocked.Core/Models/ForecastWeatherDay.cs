using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    public class ForecastWeatherDay
    {
        public DateTime Date { get; set; }
        public TimeSpan SunRiseTime { get; set; }
        public TimeSpan SunSetTime { get; set; }
        public TimeSpan MoonRiseTime { get; set; }
        public TimeSpan MoonSetTime { get; set; }
        public Temperature TemperatureMax { get; set; }
        public Temperature TemperatureMin { get; set; }
        public Precipitation PrecipitationTotal { get; set; }
        public Precipitation RainTotal { get; set; }
        public Precipitation SnowTotal { get; set; }
        public float PrecipitationProbability { get; set; }
        public float HumidityMax { get; set; }
        public float HumidityMin { get; set; }
        public Speed WindSpeedMax { get; set; }
        public Speed WindGustMax { get; set; }
        public SeaLevelPressure PressureMax { get; set; }
        public SeaLevelPressure PressureMin { get; set; }
        public ForecastWeatherTimeframe[] Timeframes { get; set; }
    }
}
