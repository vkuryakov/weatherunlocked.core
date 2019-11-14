using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherUnlocked.Core.Models;
using WeatherUnlocked.Core.Models.Responses;

namespace WeatherUnlocked.Core.Client
{
    public interface IWeatherUnlockedClient
    {
        /// <summary>
        /// Get current weather for given latitude and longitude coordinates asynchronously. Localization 
        /// will be used from application configuration or default if it is not exists in application configuration.
        /// </summary>
        /// <param name="latitude">Latitude coordinate, for example: 40.71</param>
        /// <param name="longitude">Longitude coordinate, for example: 74.00</param>
        /// <returns>Weather data for given coordinates</returns>
        Task<CurrentWeatherResponse> GetCurrentAsync(float latitude, float longitude);

        /// <summary>
        /// Get current weather for given latitude and longitude coordinates asynchronously.
        /// </summary>
        /// <param name="latitude">Latitude coordinate, for example: 40.71</param>
        /// <param name="longitude">Longitude coordinate, for example: 74.00</param>
        /// <param name="localization">Localization for weather descriptions</param>
        /// <returns>Weather data for given coordinates</returns>
        Task<CurrentWeatherResponse> GetCurrentAsync(float latitude, float longitude, Localization localization);

        /// <summary>
        /// Get current weather for given post code/zipcode asynchronously. Localization will be used from 
        /// application configuration or default if it is not exists in application configuration.
        /// </summary>
        /// <param name="code">Post code/zipcode, for example: us.33109. 
        /// More information: https://developer.weatherunlocked.com/documentation/localweather/current#Location
        /// </param>
        /// <returns>Weather data for given post code/zipcode</returns>
        Task<CurrentWeatherResponse> GetCurrentAsync(string code);

        /// <summary>
        /// Get current weather for given post code/zipcode asynchronously.
        /// </summary>
        /// <param name="code">Post code/zipcode, for example: us.33109. 
        /// More information: https://developer.weatherunlocked.com/documentation/localweather/current#Location
        /// </param>
        /// <param name="localization">Localization for weather descriptions</param>
        /// <returns>Weather data for given post code/zipcode</returns>
        Task<CurrentWeatherResponse> GetCurrentAsync(string code, Localization localization);

        /// <summary>
        /// Get forecast weather for given latitude and longitude coordinates asynchronously. Localization 
        /// will be used from application configuration or default if it is not exists in application configuration.
        /// </summary>
        /// <param name="latitude">Latitude coordinate, for example: 40.71</param>
        /// <param name="longitude">Longitude coordinate, for example: 74.00</param>
        /// <returns>Weather data for given coordinates</returns>
        Task<ForecastWeatherReponse> GetForecastAsync(float latitude, float longitude);

        /// <summary>
        /// Get forecast weather for given latitude and longitude coordinates asynchronously.
        /// </summary>
        /// <param name="latitude">Latitude coordinate, for example: 40.71</param>
        /// <param name="longitude">Longitude coordinate, for example: 74.00</param>
        /// <param name="localization">Localization for weather descriptions</param>
        /// <returns>Weather data for given coordinates</returns>
        Task<ForecastWeatherReponse> GetForecastAsync(float latitude, float longitude, Localization localization);

        /// <summary>
        /// Get forecast weather for given post code/zipcode asynchronously. Localization will be used from 
        /// application configuration or default if it is not exists in application configuration.
        /// </summary>
        /// <param name="code">Post code/zipcode, for example: us.33109. 
        /// More information: https://developer.weatherunlocked.com/documentation/localweather/forecast#Location
        /// </param>
        /// <returns>Weather data for given post code/zipcode</returns>
        Task<ForecastWeatherReponse> GetForecastAsync(string code);

        /// <summary>
        /// Get forecast weather for given post code/zipcode asynchronously.
        /// </summary>
        /// <param name="code">Post code/zipcode, for example: us.33109. 
        /// More information: https://developer.weatherunlocked.com/documentation/localweather/forecast#Location
        /// </param>
        /// <param name="localization">Localization for weather descriptions</param>
        /// <returns>Weather data for given post code/zipcode</returns>
        Task<ForecastWeatherReponse> GetForecastAsync(string code, Localization localization);
    }
}
