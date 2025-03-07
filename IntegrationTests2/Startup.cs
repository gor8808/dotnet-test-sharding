using Microsoft.Extensions.DependencyInjection;
using Xunit.DependencyInjection.Logging;

namespace IntegrationTests2;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddLogging(lb => lb.AddXunitOutput());
        services.AddScoped<IntegrationTestFixture>();
    }
}