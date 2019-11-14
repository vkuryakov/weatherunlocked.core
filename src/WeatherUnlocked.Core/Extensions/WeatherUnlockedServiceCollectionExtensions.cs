using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;
using WeatherUnlocked.Core;
using WeatherUnlocked.Core.Client;
using WeatherUnlocked.Core.Interfaces;
using WeatherUnlocked.Core.Mapping;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WeatherUnlockedServiceCollectionExtensions
    {
        public static IServiceCollection AddWeatherUnlockedService(this IServiceCollection collection)
        {
            collection.AddScoped<IWeatherUnlockedClient, WeatherUnlockedClient>();
            collection.AddScoped<IWeatherUnlockedService, WeatherUnlockedService>();
            collection.AddHttpClient();
            collection.AddAutoMapper(typeof(ResponseToModelProfile).GetTypeInfo().Assembly);
            return collection;
        }
    }
}
