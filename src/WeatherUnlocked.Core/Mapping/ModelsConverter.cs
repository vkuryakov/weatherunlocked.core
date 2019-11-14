using WeatherUnlocked.Core.Models;
using WeatherUnlocked.Core.Models.Responses;

namespace WeatherUnlocked.Core.Mapping
{
    public static class ModelsConverter
    {
        public static CurrentWeatherData ResponseToCurrentWeatherData(CurrentWeatherResponse response)
        {
            return new CurrentWeatherData()
            {
                Station = new Station()
                {
                    Latitude = response.lat,
                    Longitude = response.lon,
                    AltitudeF = response.alt_ft,
                    AltitudeM = response.alt_m
                },
                Weather = new Weather()
                {
                    Icon = response.wx_icon,
                    Code = response.wx_code,
                    Description = response.wx_desc
                },
                CloudTotal = response.cloudtotal_pct,
                DewPoint = new Temperature()
                {
                    Celcius = response.dewpoint_c,
                    Fahrenheit = response.dewpoint_f
                },
                Temperature = new Temperature()
                {
                    Celcius = response.temp_c,
                    Fahrenheit = response.temp_f
                },
                FeelsLikeTemperature = new Temperature()
                {
                    Celcius = response.feelslike_c,
                    Fahrenheit = response.feelslike_f
                },
                Humidity = response.humid_pct,
                Pressure = new SeaLevelPressure()
                {
                    Inches = response.slp_in,
                    Millibars = response.slp_mb
                },
                Visibility = new Visibility()
                {
                    Kilometers = response.vis_km,
                    Miles = response.vis_mi
                },
                Wind = new Wind()
                {
                    DirectionCompass = response.winddir_compass,
                    DirectionDeg = response.winddir_deg,
                    Speed = new Speed
                    {
                        Kmh = response.windspd_kmh,
                        Kts = response.windspd_kts,
                        Mph = response.windspd_mph,
                        Ms = response.windspd_ms
                    }

                }
            };
        }
    }
}
