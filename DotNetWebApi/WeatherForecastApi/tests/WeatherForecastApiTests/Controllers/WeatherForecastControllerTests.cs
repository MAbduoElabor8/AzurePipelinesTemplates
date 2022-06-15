using FluentAssertions;
using Microsoft.Extensions.Logging;
using NSubstitute;
using WeatherForecastApi.Controllers;

namespace WeatherForecastApiTests.Controllers;

public class WeatherForecastControllerTests
{
    private readonly ILogger<WeatherForecastController> _logger;
    
    public WeatherForecastControllerTests()
    {
        _logger = Substitute.For<ILogger<WeatherForecastController>>();
    }
    
    [Fact]
    public void Get_Returns_Forecast()
    {
        // Arrange
        var controller = new WeatherForecastController(_logger);

        // Act
        var result = controller.Get();

        // Assert
        result.Should().NotBeNull();
    }
}