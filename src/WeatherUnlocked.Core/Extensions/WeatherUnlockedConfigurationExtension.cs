using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherUnlocked.Core.Extensions;
using WeatherUnlocked.Core.Models;

namespace Microsoft.Extensions.Configuration
{
    public static class WeatherUnlockedConfigurationExtensions
    {
        public const string DEFAULT_CONFIG_SECTION = "WeatherUnlocked";

        public static WeatherUnlockedOptions GetWeatherUnlockedOptions(this IConfiguration config)
        {
            var options = new WeatherUnlockedOptions();
            IConfiguration section = config.GetSection(DEFAULT_CONFIG_SECTION);
            if (section == null)
            {
                return options;
            }
            if (!string.IsNullOrEmpty(section["AppId"]))
            {
                options.AppId = section["AppId"];
            }
            if (!string.IsNullOrEmpty(section["AppKey"]))
            {
                options.AppKey = section["AppKey"];
            }
            if (!string.IsNullOrEmpty(section["Localization"]))
            {
                if (Enum.TryParse(section["Localization"], out Localization l))
                {
                    options.Localization = l;
                }
            }

            return options;
        }
    }
}
