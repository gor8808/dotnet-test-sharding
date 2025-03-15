using Microsoft.Extensions.DependencyInjection;
using Xunit.DependencyInjection.Logging;

namespace WeatherForecastApiIntegrationTests;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<WeatherForecastApiFixture>();
    }
}
