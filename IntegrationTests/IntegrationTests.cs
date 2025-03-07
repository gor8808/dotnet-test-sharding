using Microsoft.AspNetCore.Mvc.Testing;
using WebApplication;

namespace IntegrationTests;

public class IntegrationTests
{
    private readonly WebApplicationFactory<Program> _factory = new WebApplicationFactory<Program>();
    private readonly HttpClient _cleint;

    public IntegrationTests()
    {
        _cleint = _factory.CreateClient();
    }
    
    [Theory]
    [MemberData(nameof(EnumerableRange))]
    public async Task WeatherForecast_ShouldNotBeEmpty(int number)
    {
        var response = await _cleint.GetAsync("/weatherforecast");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.NotEmpty(content);
    }

    [Theory]
    [MemberData(nameof(EnumerableRange))]
    public async Task WeatherForecast_ShouldNotBeWhiteSpace(int number)
    {
        var response = await _cleint.GetAsync("/weatherforecast");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
    }
    
    [Theory]
    [MemberData(nameof(EnumerableRange))]
    public async Task WeatherForecast_ShouldBeArray(int number)
    {
        var response = await _cleint.GetAsync("/weatherforecast");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.True(content.StartsWith('['));
        Assert.True(content.EndsWith(']'));
    }
    
    public static object[][] EnumerableRange = Enumerable.Range(1, 50).Select(i => new object[] { i }).ToArray();
}