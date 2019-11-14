using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using WeatherUnlocked.Core.Client;
using WeatherUnlocked.Core.Mapping;
using WeatherUnlocked.Core.Models;
using WeatherUnlocked.Core.Models.Responses;
using WeatherUnlocked.Core.Tests.TestData;
using Xunit;

namespace WeatherUnlocked.Core.Tests
{
    public class WeatherUnlockedTests
    {
        private readonly IWeatherUnlockedClient _mockClient;
        private readonly IMapper _mapper;

        public WeatherUnlockedTests()
        {
            _mockClient = new MockWeatherUnlockedClientBuilder()
                .WithDefaults()
                .Build();

            var mapperProfile = new ResponseToModelProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(mapperProfile));
            _mapper = new Mapper(configuration);

        }
        [Fact]
        public async void GetCurrentByCoords()
        {
            var service = new WeatherUnlockedService(_mockClient, _mapper);
            float latitude = 40.71f;
            float longitude = 74.00f;
            var result = await service.CurrentAsync(latitude, longitude, Localization.DEFAULT);
            Assert.True(CompareCurrentData(result, PredefinedData.DefaultClientCurrentResponse));
        }

        [Fact]
        public async void GetCurrentByCountryCode()
        {
            var service = new WeatherUnlockedService(_mockClient, _mapper);
            string code = "us.33109";
            var result = await service.CurrentAsync(code, Localization.DEFAULT);
            Assert.True(CompareCurrentData(result, PredefinedData.DefaultClientCurrentResponse));
        }

        [Fact]
        public async void GetForecastByCoords()
        {
            var service = new WeatherUnlockedService(_mockClient, _mapper);
            float latitude = 40.71f;
            float longitude = 74.00f;
            var result = await service.ForecastAsync(latitude, longitude, Localization.DEFAULT);
            Assert.True(CompareForecastData(result, PredefinedData.DefaultClientForecastResponse));
        }

        [Fact]
        public async void GetForecastByCountryCode()
        {
            var service = new WeatherUnlockedService(_mockClient, _mapper);
            string code = "us.33109";
            var result = await service.ForecastAsync(code, Localization.DEFAULT);
            Assert.True(CompareForecastData(result, PredefinedData.DefaultClientForecastResponse));
        }

        private bool CompareCurrentData(CurrentWeatherData currentWeatherData, CurrentWeatherResponse response)
        {
            return 
            // station
            currentWeatherData.Station.Latitude == response.lat
            && currentWeatherData.Station.Longitude == response.lon
            && currentWeatherData.Station.AltitudeF == response.alt_ft
            && currentWeatherData.Station.AltitudeM == response.alt_m
            // weather
            && string.Equals(currentWeatherData.Weather.Description, response.wx_desc)
            && currentWeatherData.Weather.Code == response.wx_code
            //&& string.Equals(currentWeatherData.Weather.Icon, response.wx_icon)
            // temperature
            && currentWeatherData.Temperature.Celcius == response.temp_c
            && currentWeatherData.Temperature.Fahrenheit == response.temp_f
            // feelslike temperature
            && currentWeatherData.FeelsLikeTemperature.Celcius == response.feelslike_c
            && currentWeatherData.FeelsLikeTemperature.Fahrenheit == response.feelslike_f
            // wind
            && currentWeatherData.Wind.Speed.Mph == response.windspd_mph
            && currentWeatherData.Wind.Speed.Kmh == response.windspd_kmh
            && currentWeatherData.Wind.Speed.Kts == response.windspd_kts
            && currentWeatherData.Wind.Speed.Ms == response.windspd_ms
            && currentWeatherData.Wind.DirectionDeg == response.winddir_deg
            && string.Equals(currentWeatherData.Wind.DirectionCompass, response.winddir_compass)
            // humidity
            && currentWeatherData.Humidity == response.humid_pct
            // cloudtotal
            && currentWeatherData.CloudTotal == response.cloudtotal_pct
            // visibility
            && currentWeatherData.Visibility.Kilometers == response.vis_km
            && currentWeatherData.Visibility.Miles == response.vis_mi
            // pressure
            && currentWeatherData.Pressure.Inches == response.slp_in
            && currentWeatherData.Pressure.Millibars == response.slp_mb
            // dewpoint
            && currentWeatherData.DewPoint.Celcius == response.dewpoint_c
            && currentWeatherData.DewPoint.Fahrenheit == response.dewpoint_f;
        }

        private bool CompareForecastData(ForecastWeatherData forecastWeatherData, ForecastWeatherReponse response)
        {
            return forecastWeatherData.Days.Length == 1
                && forecastWeatherData.Days[0].Date == response.Days[0].date
                && forecastWeatherData.Days[0].HumidityMax == response.Days[0].humid_max_pct
                && forecastWeatherData.Days[0].HumidityMin == response.Days[0].humid_min_pct
                && forecastWeatherData.Days[0].MoonRiseTime == response.Days[0].moonrise_time
                && forecastWeatherData.Days[0].MoonSetTime == response.Days[0].moonset_time
                && forecastWeatherData.Days[0].PrecipitationProbability == response.Days[0].prob_precip_pct
                && forecastWeatherData.Days[0].PrecipitationTotal.Inches == response.Days[0].precip_total_in
                && forecastWeatherData.Days[0].PrecipitationTotal.Millimeters == response.Days[0].precip_total_mm
                && forecastWeatherData.Days[0].PressureMax.Inches == response.Days[0].slp_max_in
                && forecastWeatherData.Days[0].PressureMax.Millibars == response.Days[0].slp_max_mb
                && forecastWeatherData.Days[0].PressureMin.Inches == response.Days[0].slp_min_in
                && forecastWeatherData.Days[0].PressureMin.Millibars == response.Days[0].slp_min_mb
                && forecastWeatherData.Days[0].RainTotal.Inches == response.Days[0].rain_total_in
                && forecastWeatherData.Days[0].RainTotal.Millimeters == response.Days[0].rain_total_mm
                && forecastWeatherData.Days[0].SnowTotal.Inches == response.Days[0].snow_total_in
                && forecastWeatherData.Days[0].SnowTotal.Millimeters == response.Days[0].snow_total_mm
                && forecastWeatherData.Days[0].SunRiseTime == response.Days[0].sunrise_time
                && forecastWeatherData.Days[0].SunSetTime == response.Days[0].sunset_time
                && forecastWeatherData.Days[0].TemperatureMax.Celcius == response.Days[0].temp_max_c
                && forecastWeatherData.Days[0].TemperatureMax.Fahrenheit == response.Days[0].temp_max_f
                && forecastWeatherData.Days[0].TemperatureMin.Celcius == response.Days[0].temp_min_c
                && forecastWeatherData.Days[0].TemperatureMin.Fahrenheit == response.Days[0].temp_min_f
                && forecastWeatherData.Days[0].WindGustMax.Kmh == response.Days[0].windgst_max_kmh
                && forecastWeatherData.Days[0].WindGustMax.Kts == response.Days[0].windgst_max_kts
                && forecastWeatherData.Days[0].WindGustMax.Mph == response.Days[0].windgst_max_mph
                && forecastWeatherData.Days[0].WindGustMax.Ms == response.Days[0].windgst_max_ms
                && forecastWeatherData.Days[0].WindSpeedMax.Kmh == response.Days[0].windspd_max_kmh
                && forecastWeatherData.Days[0].WindSpeedMax.Kts == response.Days[0].windspd_max_kts
                && forecastWeatherData.Days[0].WindSpeedMax.Mph == response.Days[0].windspd_max_mph
                && forecastWeatherData.Days[0].WindSpeedMax.Ms == response.Days[0].windspd_max_ms
                && forecastWeatherData.Days[0].Timeframes[0].Cloud.Total == response.Days[0].Timeframes[0].cloudtotal_pct
                && forecastWeatherData.Days[0].Timeframes[0].Cloud.HighLevelAmount == response.Days[0].Timeframes[0].cloud_high_pct
                && forecastWeatherData.Days[0].Timeframes[0].Cloud.MidLevelAmount == response.Days[0].Timeframes[0].cloud_mid_pct
                && forecastWeatherData.Days[0].Timeframes[0].Cloud.LowLevelAmount == response.Days[0].Timeframes[0].cloud_low_pct
                && forecastWeatherData.Days[0].Timeframes[0].Date == response.Days[0].Timeframes[0].date
                && forecastWeatherData.Days[0].Timeframes[0].DewPoint.Celcius == response.Days[0].Timeframes[0].dewpoint_c
                && forecastWeatherData.Days[0].Timeframes[0].DewPoint.Fahrenheit == response.Days[0].Timeframes[0].dewpoint_f
                && forecastWeatherData.Days[0].Timeframes[0].FeelsLikeTemperature.Celcius == response.Days[0].Timeframes[0].feelslike_c
                && forecastWeatherData.Days[0].Timeframes[0].FeelsLikeTemperature.Fahrenheit == response.Days[0].Timeframes[0].feelslike_f
                && forecastWeatherData.Days[0].Timeframes[0].Temperature.Celcius == response.Days[0].Timeframes[0].temp_c
                && forecastWeatherData.Days[0].Timeframes[0].Temperature.Fahrenheit == response.Days[0].Timeframes[0].temp_f
                && forecastWeatherData.Days[0].Timeframes[0].Humidity == response.Days[0].Timeframes[0].humid_pct
                && forecastWeatherData.Days[0].Timeframes[0].Precipitation.Inches == response.Days[0].Timeframes[0].precip_in
                && forecastWeatherData.Days[0].Timeframes[0].Precipitation.Millimeters == response.Days[0].Timeframes[0].precip_mm
                && forecastWeatherData.Days[0].Timeframes[0].PrecipitationProbability == response.Days[0].Timeframes[0].prob_precip_pct
                && forecastWeatherData.Days[0].Timeframes[0].Pressure.Inches == response.Days[0].Timeframes[0].slp_in
                && forecastWeatherData.Days[0].Timeframes[0].Pressure.Millibars == response.Days[0].Timeframes[0].slp_mb
                && forecastWeatherData.Days[0].Timeframes[0].Rain.Inches == response.Days[0].Timeframes[0].rain_in
                && forecastWeatherData.Days[0].Timeframes[0].Rain.Millimeters == response.Days[0].Timeframes[0].rain_mm
                && forecastWeatherData.Days[0].Timeframes[0].Snow.Inches == response.Days[0].Timeframes[0].snow_in
                && forecastWeatherData.Days[0].Timeframes[0].Snow.Millimeters == response.Days[0].Timeframes[0].snow_mm
                && forecastWeatherData.Days[0].Timeframes[0].Snowfall.Inches == response.Days[0].Timeframes[0].snow_accum_in
                && forecastWeatherData.Days[0].Timeframes[0].Snowfall.Centimetres == response.Days[0].Timeframes[0].snow_accum_cm
                && forecastWeatherData.Days[0].Timeframes[0].Time == response.Days[0].Timeframes[0].time
                && forecastWeatherData.Days[0].Timeframes[0].UtcDate == response.Days[0].Timeframes[0].utcdate
                && forecastWeatherData.Days[0].Timeframes[0].UtcTime == response.Days[0].Timeframes[0].utctime
                && forecastWeatherData.Days[0].Timeframes[0].Visibility.Kilometers == response.Days[0].Timeframes[0].vis_km
                && forecastWeatherData.Days[0].Timeframes[0].Visibility.Miles == response.Days[0].Timeframes[0].vis_mi
                && forecastWeatherData.Days[0].Timeframes[0].Weather.Code == response.Days[0].Timeframes[0].wx_code
                && forecastWeatherData.Days[0].Timeframes[0].Weather.Description == response.Days[0].Timeframes[0].wx_desc
                && forecastWeatherData.Days[0].Timeframes[0].Weather.Icon == response.Days[0].Timeframes[0].wx_icon
                && forecastWeatherData.Days[0].Timeframes[0].Wind.DirectionCompass == response.Days[0].Timeframes[0].winddir_compass
                && forecastWeatherData.Days[0].Timeframes[0].Wind.DirectionDeg == response.Days[0].Timeframes[0].winddir_deg
                && forecastWeatherData.Days[0].Timeframes[0].Wind.Gust.Kmh == response.Days[0].Timeframes[0].windgst_kmh
                && forecastWeatherData.Days[0].Timeframes[0].Wind.Gust.Kts == response.Days[0].Timeframes[0].windgst_kts
                && forecastWeatherData.Days[0].Timeframes[0].Wind.Gust.Mph == response.Days[0].Timeframes[0].windgst_mph
                && forecastWeatherData.Days[0].Timeframes[0].Wind.Gust.Ms == response.Days[0].Timeframes[0].windgst_ms
                && forecastWeatherData.Days[0].Timeframes[0].Wind.Speed.Kmh == response.Days[0].Timeframes[0].windspd_kmh
                && forecastWeatherData.Days[0].Timeframes[0].Wind.Speed.Kts == response.Days[0].Timeframes[0].windspd_kts
                && forecastWeatherData.Days[0].Timeframes[0].Wind.Speed.Mph == response.Days[0].Timeframes[0].windspd_mph
                && forecastWeatherData.Days[0].Timeframes[0].Wind.Speed.Ms == response.Days[0].Timeframes[0].windspd_ms;
        }
    }
}
