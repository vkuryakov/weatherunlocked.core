using System;
using System.Collections.Generic;
using System.Text;
using WeatherUnlocked.Core.Models;

namespace WeatherUnlocked.Core.Extensions
{
    public class WeatherUnlockedOptions
    {
        public string AppId { get; set; }
        public string AppKey { get; set; }
        public Localization Localization { get; set; } = Localization.DEFAULT;
    }
}
