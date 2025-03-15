using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using WeatherForecastApi;
using Xunit.DependencyInjection.Logging;

namespace WeatherForecastApiIntegrationTests;

public class WeatherForecastApiFixture
{
    public readonly WebApplicationFactory<Program> Factory = new();

    public WeatherForecastApiFixture()
    {
        Factory.WithWebHostBuilder(b => b.ConfigureServices(services =>
        {
            
        }));
        _ = Factory.Services; // Start application
    }
}
