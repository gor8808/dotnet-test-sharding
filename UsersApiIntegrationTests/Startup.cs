using Microsoft.Extensions.DependencyInjection;
using Xunit.DependencyInjection.Logging;

namespace UsersApiIntegrationTests;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddLogging(lb => lb.AddXunitOutput());
        services.AddScoped<UsersApiFixture>();
    }
}