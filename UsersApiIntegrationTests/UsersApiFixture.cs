using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Xunit.DependencyInjection.Logging;
using UsersApi;
namespace UsersApiIntegrationTests;

public class UsersApiFixture
{
    public readonly WebApplicationFactory<Program> Factory = new();

    public UsersApiFixture()
    {
        Factory.WithWebHostBuilder(b => b.ConfigureServices(services =>
        {
            
        }));
        
        _ = Factory.Services; // Start application
    }
}
