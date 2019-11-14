using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models.Responses
{
    /// <summary>
    /// Response model for forecast weather request.
    /// </summary>
    public class ForecastWeatherReponse
    {
        public List<ForecastDayResponse> Days { get; set; }
    }
}
