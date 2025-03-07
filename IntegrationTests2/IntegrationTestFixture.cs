using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using WebApplication;
using Xunit.DependencyInjection.Logging;

namespace IntegrationTests2;

public class IntegrationTestFixture
{
    public readonly WebApplicationFactory<Program> Factory = new();

    public IntegrationTestFixture()
    {
        Factory.WithWebHostBuilder(b => b.ConfigureServices(services =>
        {
            services.AddLogging(lb => lb.AddXunitOutput());
        }));
        _ = Factory.Services; // Start application
    }
}