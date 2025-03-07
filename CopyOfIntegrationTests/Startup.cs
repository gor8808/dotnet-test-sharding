using Microsoft.Extensions.DependencyInjection;
using Xunit.DependencyInjection.Logging;

namespace CopyOfIntegrationTests;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddLogging(lb => lb.AddXunitOutput());
        services.AddScoped<CopyOfIntegrationTestsIntegrationTestFixture>();
    }
}