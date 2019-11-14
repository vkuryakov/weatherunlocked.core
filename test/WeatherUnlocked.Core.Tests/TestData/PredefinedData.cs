using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WeatherUnlocked.Core.Models;
using WeatherUnlocked.Core.Models.Responses;

namespace WeatherUnlocked.Core.Tests.TestData
{
    public static class PredefinedData
    {
        public static CurrentWeatherResponse DefaultClientCurrentResponse = new CurrentWeatherResponse()
        {
            lat = 55.4f,
            lon = 37.9f,
            alt_ft = 587.27f,
            alt_m = 179.0f,
            wx_desc = "Light rain",
            wx_code = 61,
            wx_icon = "OccLightRain.gif",
            temp_c = 4.0f,
            temp_f = 39.2f,
            feelslike_c = -0.05f,
            feelslike_f = 31.91f,
            humid_pct = 87,
            windspd_mph = 11.81f,
            windspd_kmh = 19.0f,
            windspd_kts = 10.26f,
            windspd_ms = 5.28f,
            winddir_deg = 210,
            winddir_compass = "SSW",
            cloudtotal_pct = 100.0f,
            vis_km = 10.0f,
            vis_mi = 6.21f,
            slp_mb = 1008.1f,
            slp_in = 29.85f,
            dewpoint_c = 2.04f,
            dewpoint_f = 35.68f
        };

        public static ForecastWeatherReponse DefaultClientForecastResponse = new ForecastWeatherReponse()
        {
            Days = new List<ForecastDayResponse>()
            {
                new ForecastDayResponse()
                {
                    date = new DateTime(2019,10,29),
                    humid_max_pct = 0.2f,
                    humid_min_pct = 0.1f,
                    moonrise_time = TimeSpan.MinValue,
                    moonset_time = TimeSpan.MaxValue,
                    precip_total_in = 1.1f,
                    precip_total_mm = 2.1f,
                    prob_precip_pct = 3.1f,
                    rain_total_in = 4.1f,
                    rain_total_mm = 5.1f,
                    slp_max_in = 6.1f,
                    slp_max_mb = 7.1f,
                    slp_min_in = 8.1f,
                    slp_min_mb = 9.1f,
                    snow_total_in = 10.1f,
                    snow_total_mm = 11.1f,
                    sunrise_time = TimeSpan.MinValue,
                    sunset_time = TimeSpan.MaxValue,
                    temp_max_c = 12.1f,
                    temp_max_f = 13.1f,
                    temp_min_c = 14.1f,
                    temp_min_f = 15.1f,
                    windgst_max_kmh = 16.1f,
                    windgst_max_kts = 17.1f,
                    windgst_max_mph = 18.1f,
                    windgst_max_ms = 19.1f,
                    windspd_max_kmh = 20.1f,
                    windspd_max_kts = 21.1f,
                    windspd_max_mph = 22.1f,
                    windspd_max_ms = 23.1f,
                    Timeframes = new ForecastTimeframeResponse[]
                    {
                        new ForecastTimeframeResponse
                        {
                            cloudtotal_pct = 0.1f,
                            cloud_high_pct = 1.1f,
                            cloud_low_pct = 2.1f,
                            cloud_mid_pct = 3.1f,
                            date = DateTime.Now,
                            dewpoint_c = 4.1f,
                            dewpoint_f = 5.1f,
                            feelslike_c = 6.1f,
                            feelslike_f = 7.1f,
                            humid_pct = 8.1f,
                            precip_in = 9.1f,
                            precip_mm = 10.1f,
                            prob_precip_pct = "prob_precip_pct",
                            rain_in = 12.1f,
                            rain_mm = 13.1f,
                            slp_in = 14.1f,
                            slp_mb = 15.1f,
                            snow_accum_cm = 16.1f,
                            snow_accum_in = 17.1f,
                            snow_in = 18.1f,
                            snow_mm = 19.1f,
                            temp_c = 20.1f,
                            temp_f = 21.1f,
                            time = TimeSpan.MinValue,
                            utcdate = DateTime.UtcNow,
                            utctime = DateTime.UtcNow.TimeOfDay,
                            vis_km = 22.1f,
                            vis_mi = 23.1f,
                            winddir_compass = "S",
                            winddir_deg = 24.1f,
                            windgst_kmh = 25.1f,
                            windgst_kts = 26.1f,
                            windgst_mph = 27.1f,
                            windgst_ms = 28.1f,
                            windspd_kmh = 29.1f,
                            windspd_kts = 30.1f,
                            windspd_mph = 31.1f,
                            windspd_ms = 32.1f,
                            wx_code = 33,
                            wx_desc = "rain",
                            wx_icon = "http://icon"
                        }
                    }
                }
            }
        };
    }
}
