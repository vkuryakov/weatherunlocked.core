# Weather Unlocked Client
[![Build status](https://ci.appveyor.com/api/projects/status/fv8g176hscmt0b1o?svg=true)](https://ci.appveyor.com/project/drakar4ik/readmetest)

An asynchronous .NET Core client for Local Weather API of Weather Unlocked service.

Features
   - Search by geographic coordinates or post code/zipcode;
   - Multiple language;

Types of weather data supported:
   - Current weather
   - 7-day forecast (every 3 hours)

## Getting Started

Add Weather Unlocked AppId and AppKey to the appsettings. You can get them on the Weather Unlocked site after registration.
Example: 

		{
		  ...
		  "WeatherUnlocked": {
		    "AppId": "xxxxxxxx",
		    "AppKey": "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
		  }
		  ...
		}

Add Weather Unlocked service in startup.cs:

        public void ConfigureServices(IServiceCollection services)
        {
        	...
            services.AddWeatherUnlockedService();
            ...
        }

Now you can pass Weather Unlocked client via DI:
    public class MyController : ControllerBase
    {
        private readonly IWeatherUnlockedService _client;
        public MyController(IWeatherUnlockedService client)
        {
            _client = client;
        }

        ...
    }

and use it in your code:

	CurrentWeatherData result = await _client.CurrentAsync(40.7128f, 74.0060f);
	ForecastWeatherData result = await _client.ForecastAsync(40.7128f, 74.0060f);

## Authors

* **Vladimir Kuryakov** - [vkuryakov](https://github.com/vkuryakov)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details


