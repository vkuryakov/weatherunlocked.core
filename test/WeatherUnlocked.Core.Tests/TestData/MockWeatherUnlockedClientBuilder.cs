using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherUnlocked.Core.Client;
using WeatherUnlocked.Core.Models;

namespace WeatherUnlocked.Core.Tests.TestData
{
    public class MockWeatherUnlockedClientBuilder
    {
        private Mock<IWeatherUnlockedClient> _mockClient = new Mock<IWeatherUnlockedClient>();

        public MockWeatherUnlockedClientBuilder WithDefaults()
        {
            WithCurrentResponseAsync();
            return this;
        }

        public MockWeatherUnlockedClientBuilder WithCurrentResponseAsync()
        {
            _mockClient
                .Setup(c => c.GetCurrentAsync(It.IsAny<float>(), It.IsAny<float>(), Localization.DEFAULT))
                .Returns(Task.FromResult(PredefinedData.DefaultClientCurrentResponse));

            _mockClient
                .Setup(c => c.GetCurrentAsync(It.IsAny<string>(), Localization.DEFAULT))
                .Returns(Task.FromResult(PredefinedData.DefaultClientCurrentResponse));

            _mockClient
                .Setup(c => c.GetForecastAsync(It.IsAny<float>(), It.IsAny<float>(), Localization.DEFAULT))
                .Returns(Task.FromResult(PredefinedData.DefaultClientForecastResponse));

            _mockClient
                .Setup(c => c.GetForecastAsync(It.IsAny<string>(), Localization.DEFAULT))
                .Returns(Task.FromResult(PredefinedData.DefaultClientForecastResponse));
            return this;
        }

        public IWeatherUnlockedClient Build()
        {
            return _mockClient.Object;
        }
    }
}
