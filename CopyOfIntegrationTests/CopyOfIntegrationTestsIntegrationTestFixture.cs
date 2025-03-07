using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using WebApplication;
using Xunit.DependencyInjection.Logging;

namespace CopyOfIntegrationTests;

public class CopyOfIntegrationTestsIntegrationTestFixture
{
    public readonly WebApplicationFactory<Program> Factory = new();

    public CopyOfIntegrationTestsIntegrationTestFixture()
    {
        Factory.WithWebHostBuilder(b => b.ConfigureServices(services =>
        {
            services.AddLogging(lb => lb.AddXunitOutput());
        }));
        _ = Factory.Services; // Start application
    }
}