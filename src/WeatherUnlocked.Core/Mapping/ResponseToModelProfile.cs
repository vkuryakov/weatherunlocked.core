using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherUnlocked.Core.Models;
using WeatherUnlocked.Core.Models.Responses;

namespace WeatherUnlocked.Core.Mapping
{
    public class ResponseToModelProfile : Profile
    {
        public ResponseToModelProfile()
        {
            CreateMap<CurrentWeatherData, CurrentWeatherResponse>()
                // Station
                .ForMember(dest => dest.lat, opt => opt.MapFrom(src => src.Station.Latitude))
                .ForMember(dest => dest.lon, opt => opt.MapFrom(src => src.Station.Longitude))
                .ForMember(dest => dest.alt_ft, opt => opt.MapFrom(src => src.Station.AltitudeF))
                .ForMember(dest => dest.alt_m, opt => opt.MapFrom(src => src.Station.AltitudeM))
                // Weather
                .ForMember(dest => dest.wx_desc, opt => opt.MapFrom(src => src.Weather.Description))
                .ForMember(dest => dest.wx_code, opt => opt.MapFrom(src => src.Weather.Code))
                .ForMember(dest => dest.wx_icon, opt => opt.MapFrom(src => src.Weather.Icon))
                // Temperature
                .ForMember(dest => dest.temp_c, opt => opt.MapFrom(src => src.Temperature.Celcius))
                .ForMember(dest => dest.temp_f, opt => opt.MapFrom(src => src.Temperature.Fahrenheit))
                // Feels like temperature
                .ForMember(dest => dest.feelslike_c, opt => opt.MapFrom(src => src.FeelsLikeTemperature.Celcius))
                .ForMember(dest => dest.feelslike_f, opt => opt.MapFrom(src => src.FeelsLikeTemperature.Fahrenheit))
                // Wind
                .ForMember(dest => dest.windspd_kmh, opt => opt.MapFrom(src => src.Wind.Speed.Kmh))
                .ForMember(dest => dest.windspd_kts, opt => opt.MapFrom(src => src.Wind.Speed.Kts))
                .ForMember(dest => dest.windspd_mph, opt => opt.MapFrom(src => src.Wind.Speed.Mph))
                .ForMember(dest => dest.windspd_ms, opt => opt.MapFrom(src => src.Wind.Speed.Ms))
                .ForMember(dest => dest.winddir_compass, opt => opt.MapFrom(src => src.Wind.DirectionCompass))
                .ForMember(dest => dest.winddir_deg, opt => opt.MapFrom(src => src.Wind.DirectionDeg))
                // Humidity
                .ForMember(dest => dest.humid_pct, opt => opt.MapFrom(src => src.Humidity))
                // Cloud total
                .ForMember(dest => dest.cloudtotal_pct, opt => opt.MapFrom(src => src.CloudTotal))
                // Visibility
                .ForMember(dest => dest.vis_km, opt => opt.MapFrom(src => src.Visibility.Kilometers))
                .ForMember(dest => dest.vis_mi, opt => opt.MapFrom(src => src.Visibility.Miles))
                // Pressure
                .ForMember(dest => dest.slp_in, opt => opt.MapFrom(src => src.Pressure.Inches))
                .ForMember(dest => dest.slp_mb, opt => opt.MapFrom(src => src.Pressure.Millibars))
                // Dew point
                .ForMember(dest => dest.dewpoint_c, opt => opt.MapFrom(src => src.DewPoint.Celcius))
                .ForMember(dest => dest.dewpoint_f, opt => opt.MapFrom(src => src.DewPoint.Fahrenheit))
                .ReverseMap();

            CreateMap<ForecastWeatherReponse, ForecastWeatherData>();
            CreateMap<ForecastWeatherDay, ForecastDayResponse>()
                .ForMember(dest => dest.date, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.humid_max_pct, opt => opt.MapFrom(src => src.HumidityMax))
                .ForMember(dest => dest.humid_min_pct, opt => opt.MapFrom(src => src.HumidityMin))
                .ForMember(dest => dest.moonrise_time, opt => opt.MapFrom(src => src.MoonRiseTime))
                .ForMember(dest => dest.moonset_time, opt => opt.MapFrom(src => src.MoonSetTime))
                .ForMember(dest => dest.precip_total_in, opt => opt.MapFrom(src => src.PrecipitationTotal.Inches))
                .ForMember(dest => dest.precip_total_mm, opt => opt.MapFrom(src => src.PrecipitationTotal.Millimeters))
                .ForMember(dest => dest.prob_precip_pct, opt => opt.MapFrom(src => src.PrecipitationProbability))
                .ForMember(dest => dest.rain_total_in, opt => opt.MapFrom(src => src.RainTotal.Inches))
                .ForMember(dest => dest.rain_total_mm, opt => opt.MapFrom(src => src.RainTotal.Millimeters))
                .ForMember(dest => dest.slp_max_in, opt => opt.MapFrom(src => src.PressureMax.Inches))
                .ForMember(dest => dest.slp_max_mb, opt => opt.MapFrom(src => src.PressureMax.Millibars))
                .ForMember(dest => dest.slp_min_in, opt => opt.MapFrom(src => src.PressureMin.Inches))
                .ForMember(dest => dest.slp_min_mb, opt => opt.MapFrom(src => src.PressureMin.Millibars))
                .ForMember(dest => dest.snow_total_in, opt => opt.MapFrom(src => src.SnowTotal.Inches))
                .ForMember(dest => dest.snow_total_mm, opt => opt.MapFrom(src => src.SnowTotal.Millimeters))
                .ForMember(dest => dest.sunrise_time, opt => opt.MapFrom(src => src.SunRiseTime))
                .ForMember(dest => dest.sunset_time, opt => opt.MapFrom(src => src.SunSetTime))
                .ForMember(dest => dest.temp_max_c, opt => opt.MapFrom(src => src.TemperatureMax.Celcius))
                .ForMember(dest => dest.temp_max_f, opt => opt.MapFrom(src => src.TemperatureMax.Fahrenheit))
                .ForMember(dest => dest.temp_min_c, opt => opt.MapFrom(src => src.TemperatureMin.Celcius))
                .ForMember(dest => dest.temp_min_f, opt => opt.MapFrom(src => src.TemperatureMin.Fahrenheit))
                .ForMember(dest => dest.windgst_max_kmh, opt => opt.MapFrom(src => src.WindGustMax.Kmh))
                .ForMember(dest => dest.windgst_max_kts, opt => opt.MapFrom(src => src.WindGustMax.Kts))
                .ForMember(dest => dest.windgst_max_mph, opt => opt.MapFrom(src => src.WindGustMax.Mph))
                .ForMember(dest => dest.windgst_max_ms, opt => opt.MapFrom(src => src.WindGustMax.Ms))
                .ForMember(dest => dest.windspd_max_kmh, opt => opt.MapFrom(src => src.WindSpeedMax.Kmh))
                .ForMember(dest => dest.windspd_max_kts, opt => opt.MapFrom(src => src.WindSpeedMax.Kts))
                .ForMember(dest => dest.windspd_max_mph, opt => opt.MapFrom(src => src.WindSpeedMax.Mph))
                .ForMember(dest => dest.windspd_max_ms, opt => opt.MapFrom(src => src.WindSpeedMax.Ms))
                .ReverseMap();
            CreateMap<ForecastWeatherTimeframe, ForecastTimeframeResponse>()
                .ForMember(dest => dest.date, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.cloudtotal_pct, opt => opt.MapFrom(src => src.Cloud.Total))
                .ForMember(dest => dest.cloud_high_pct, opt => opt.MapFrom(src => src.Cloud.HighLevelAmount))
                .ForMember(dest => dest.cloud_mid_pct, opt => opt.MapFrom(src => src.Cloud.MidLevelAmount))
                .ForMember(dest => dest.cloud_low_pct, opt => opt.MapFrom(src => src.Cloud.LowLevelAmount))
                .ForMember(dest => dest.dewpoint_c, opt => opt.MapFrom(src => src.DewPoint.Celcius))
                .ForMember(dest => dest.dewpoint_f, opt => opt.MapFrom(src => src.DewPoint.Fahrenheit))
                .ForMember(dest => dest.feelslike_c, opt => opt.MapFrom(src => src.FeelsLikeTemperature.Celcius))
                .ForMember(dest => dest.feelslike_f, opt => opt.MapFrom(src => src.FeelsLikeTemperature.Fahrenheit))
                .ForMember(dest => dest.humid_pct, opt => opt.MapFrom(src => src.Humidity))
                .ForMember(dest => dest.precip_in, opt => opt.MapFrom(src => src.Precipitation.Inches))
                .ForMember(dest => dest.precip_mm, opt => opt.MapFrom(src => src.Precipitation.Millimeters))
                .ForMember(dest => dest.prob_precip_pct, opt => opt.MapFrom(src => src.PrecipitationProbability))
                .ForMember(dest => dest.rain_in, opt => opt.MapFrom(src => src.Rain.Inches))
                .ForMember(dest => dest.rain_mm, opt => opt.MapFrom(src => src.Rain.Millimeters))
                .ForMember(dest => dest.slp_in, opt => opt.MapFrom(src => src.Pressure.Inches))
                .ForMember(dest => dest.slp_mb, opt => opt.MapFrom(src => src.Pressure.Millibars))
                .ForMember(dest => dest.snow_accum_cm, opt => opt.MapFrom(src => src.Snowfall.Centimetres))
                .ForMember(dest => dest.snow_accum_in, opt => opt.MapFrom(src => src.Snowfall.Inches))
                .ForMember(dest => dest.snow_in, opt => opt.MapFrom(src => src.Snow.Inches))
                .ForMember(dest => dest.snow_mm, opt => opt.MapFrom(src => src.Snow.Millimeters))
                .ForMember(dest => dest.temp_c, opt => opt.MapFrom(src => src.Temperature.Celcius))
                .ForMember(dest => dest.temp_f, opt => opt.MapFrom(src => src.Temperature.Fahrenheit))
                .ForMember(dest => dest.time, opt => opt.MapFrom(src => src.Time))
                .ForMember(dest => dest.utcdate, opt => opt.MapFrom(src => src.UtcDate))
                .ForMember(dest => dest.utctime, opt => opt.MapFrom(src => src.UtcTime))
                .ForMember(dest => dest.vis_km, opt => opt.MapFrom(src => src.Visibility.Kilometers))
                .ForMember(dest => dest.vis_mi, opt => opt.MapFrom(src => src.Visibility.Miles))
                .ForMember(dest => dest.winddir_compass, opt => opt.MapFrom(src => src.Wind.DirectionCompass))
                .ForMember(dest => dest.winddir_deg, opt => opt.MapFrom(src => src.Wind.DirectionDeg))
                .ForMember(dest => dest.windgst_kmh, opt => opt.MapFrom(src => src.Wind.Gust.Kmh))
                .ForMember(dest => dest.windgst_kts, opt => opt.MapFrom(src => src.Wind.Gust.Kts))
                .ForMember(dest => dest.windgst_mph, opt => opt.MapFrom(src => src.Wind.Gust.Mph))
                .ForMember(dest => dest.windgst_ms, opt => opt.MapFrom(src => src.Wind.Gust.Ms))
                .ForMember(dest => dest.windspd_kmh, opt => opt.MapFrom(src => src.Wind.Speed.Kmh))
                .ForMember(dest => dest.windspd_kts, opt => opt.MapFrom(src => src.Wind.Speed.Kts))
                .ForMember(dest => dest.windspd_mph, opt => opt.MapFrom(src => src.Wind.Speed.Mph))
                .ForMember(dest => dest.windspd_ms, opt => opt.MapFrom(src => src.Wind.Speed.Ms))
                .ForMember(dest => dest.wx_code, opt => opt.MapFrom(src => src.Weather.Code))
                .ForMember(dest => dest.wx_desc, opt => opt.MapFrom(src => src.Weather.Description))
                .ForMember(dest => dest.wx_icon, opt => opt.MapFrom(src => src.Weather.Icon))
                .ReverseMap();
        }
    }
}
