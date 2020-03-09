using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherUnlocked.Core.Exceptions;
using WeatherUnlocked.Core.Extensions;
using WeatherUnlocked.Core.JsonConverters;
using WeatherUnlocked.Core.Models;
using WeatherUnlocked.Core.Models.Responses;

namespace WeatherUnlocked.Core.Client
{
    /// <summary>
    /// WeatherUnlocked API asynchronous client.
    /// </summary>
    public class WeatherUnlockedClient : IWeatherUnlockedClient
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly WeatherUnlockedOptions _options;
        private readonly string BaseURL = "http://api.weatherunlocked.com/";
        public WeatherUnlockedClient(IConfiguration configuration,
            IHttpClientFactory clientFactory)
        {
            _options = configuration.GetWeatherUnlockedOptions();
            _clientFactory = clientFactory;
        }

        public async Task<CurrentWeatherResponse> GetCurrentAsync(float latitude, float longitude)
        {
            return await GetCurrentAsync(latitude, longitude, _options.Localization).ConfigureAwait(false);
        }

        public async Task<CurrentWeatherResponse> GetCurrentAsync(float latitude, float longitude, Localization localization)
        {
            string url = string.Format("{0}api/current/{1},{2}?{3}", BaseURL, latitude.ToString(), longitude.ToString(), BuildQueryString(localization));
            string result = await SendRequestAsync(url).ConfigureAwait(false);
            return DeserializeJson<CurrentWeatherResponse>(result);
        }

        public async Task<CurrentWeatherResponse> GetCurrentAsync(string code)
        {
            return await GetCurrentAsync(code, _options.Localization).ConfigureAwait(false);
        }

        public async Task<CurrentWeatherResponse> GetCurrentAsync(string code, Localization localization)
        {
            string url = string.Format("{0}api/current/{1}?{2}", BaseURL, code, BuildQueryString(localization));
            string result = await SendRequestAsync(url).ConfigureAwait(false);
            return DeserializeJson<CurrentWeatherResponse>(result);
        }

        public async Task<ForecastWeatherReponse> GetForecastAsync(float latitude, float longitude)
        {
            return await GetForecastAsync(latitude, longitude, _options.Localization).ConfigureAwait(false);
        }

        public async Task<ForecastWeatherReponse> GetForecastAsync(float latitude, float longitude, Localization localization)
        {
            string url = string.Format("{0}api/forecast/{1},{2}?{3}", BaseURL, latitude.ToString(), longitude.ToString(), BuildQueryString(localization));
            string result = await SendRequestAsync(url).ConfigureAwait(false);
            return DeserializeJson<ForecastWeatherReponse>(result);
        }

        public async Task<ForecastWeatherReponse> GetForecastAsync(string code)
        {
            return await GetForecastAsync(code, _options.Localization).ConfigureAwait(false);
        }

        public async Task<ForecastWeatherReponse> GetForecastAsync(string code, Localization localization)
        {
            string url = string.Format("{0}api/forecast/{1}?{2}", BaseURL, code, BuildQueryString(localization));
            string result = await SendRequestAsync(url).ConfigureAwait(false);
            return DeserializeJson<ForecastWeatherReponse>(result);
        }

        private T DeserializeJson<T>(string json)
        {
            var format = "dd/MM/yyyy"; // your datetime format
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = format };
            return JsonConvert.DeserializeObject<T>(json, dateTimeConverter);
        }

        private string BuildQueryString(Localization localization)
        {
            string langParam = localization != Localization.DEFAULT ? "lang=" + localization.ToString() + "&" : "";
            return string.Format("{0}app_id={1}&app_key={2}", langParam, _options.AppId, _options.AppKey);
        }

        private async Task<string> SendRequestAsync(string url)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var client = _clientFactory.CreateClient();
            var clientResponse = await client.SendAsync(request).ConfigureAwait(false);
            var result = await clientResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (clientResponse.StatusCode == HttpStatusCode.Forbidden)
            {
                throw new ForbiddenException(result);
            }
            
            if (clientResponse.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpException(clientResponse);
            }
            
            return result;
        }


    }
}
