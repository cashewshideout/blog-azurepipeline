using BasicCoreApp.Controllers;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BasicCoreApp.Tests
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void WeatherForecast_ReturnsMoreThanOne()
        {
            var controller = new WeatherForecastController();
            IEnumerable<WeatherForecast> result = controller.Get();


            Assert.True(result.ToList().Count() > 1);
        }
    }
}
