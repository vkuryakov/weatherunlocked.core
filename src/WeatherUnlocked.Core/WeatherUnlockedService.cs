using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherUnlocked.Core.Client;
using WeatherUnlocked.Core.Interfaces;
using WeatherUnlocked.Core.Mapping;
using WeatherUnlocked.Core.Models;
using WeatherUnlocked.Core.Models.Responses;

namespace WeatherUnlocked.Core
{
    /// <summary>
    /// This service is a client for WeatherUnlocked API (http://www.weatherunlocked.com/).
    /// The service needs next settings in app configuration:
    ///    "WeatherUnlocked": {
    ///      "AppId": "[app_id]",
    ///      "AppKey": "[app_key]",
    ///      "Localization": "[Localization]"
    ///    }
    /// notes:
    /// [app_id] - required parameter. Application id (you can find it in admin dashboard of your account 
    /// on https://developer.weatherunlocked.com/admin)
    /// [app_key] - required parameter. Application key (you can find it in admin dashboard of your account 
    /// on https://developer.weatherunlocked.com/admin)
    /// [Localization] - optional parameter. Default localization for weather data. One of values from Language
    /// part of documentation here: https://developer.weatherunlocked.com/documentation/localweather/current#Language
    /// 
    /// To use the service just call extension AddWeatherUnlockedService on ServiceCollection.
    /// </summary>
    public class WeatherUnlockedService : IWeatherUnlockedService
    {
        private readonly IWeatherUnlockedClient _client;
        private readonly IMapper _mapper;
        public WeatherUnlockedService(IWeatherUnlockedClient client,
            IMapper mapper)
        {
            _client = client;
            _mapper = mapper;
        }

        public async Task<CurrentWeatherData> CurrentAsync(float latitude, float longitude)
        {
            var resp = await _client.GetCurrentAsync(latitude, longitude).ConfigureAwait(false);
            return _mapper.Map<CurrentWeatherResponse, CurrentWeatherData>(resp);
        }

        public async Task<CurrentWeatherData> CurrentAsync(float latitude, float longitude, Localization localization)
        {
            var resp = await _client.GetCurrentAsync(latitude, longitude, localization).ConfigureAwait(false);
            return _mapper.Map<CurrentWeatherResponse, CurrentWeatherData>(resp);
        }

        public async Task<CurrentWeatherData> CurrentAsync(string code)
        {
            var resp = await _client.GetCurrentAsync(code).ConfigureAwait(false);
            return _mapper.Map<CurrentWeatherResponse, CurrentWeatherData>(resp);
        }

        public async Task<CurrentWeatherData> CurrentAsync(string code, Localization localization)
        {
            var resp = await _client.GetCurrentAsync(code, localization).ConfigureAwait(false);
            return _mapper.Map<CurrentWeatherResponse, CurrentWeatherData>(resp);
        }

        public async Task<ForecastWeatherData> ForecastAsync(float latitude, float longitude)
        {
            var resp = await _client.GetForecastAsync(latitude, longitude).ConfigureAwait(false);
            return _mapper.Map<ForecastWeatherReponse, ForecastWeatherData>(resp);
        }

        public async Task<ForecastWeatherData> ForecastAsync(float latitude, float longitude, Localization localization)
        {
            var resp = await _client.GetForecastAsync(latitude, longitude, localization).ConfigureAwait(false);
            return _mapper.Map<ForecastWeatherReponse, ForecastWeatherData>(resp);
        }

        public async Task<ForecastWeatherData> ForecastAsync(string code)
        {
            var resp = await _client.GetForecastAsync(code).ConfigureAwait(false);
            return _mapper.Map<ForecastWeatherReponse, ForecastWeatherData>(resp);
        }

        public async Task<ForecastWeatherData> ForecastAsync(string code, Localization localization)
        {
            var resp = await _client.GetForecastAsync(code, localization).ConfigureAwait(false);
            return _mapper.Map<ForecastWeatherReponse, ForecastWeatherData>(resp);
        }
    }
}
