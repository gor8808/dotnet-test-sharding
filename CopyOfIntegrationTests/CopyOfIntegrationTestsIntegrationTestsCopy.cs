using Microsoft.AspNetCore.Mvc.Testing;
using WebApplication;

namespace CopyOfIntegrationTests;

public class CopyOfIntegrationTestsIntegrationTestsCopy
{
    private readonly HttpClient _cleint;

    public CopyOfIntegrationTestsIntegrationTestsCopy(CopyOfIntegrationTestsIntegrationTestFixture fixture)
    {
        _cleint = fixture.Factory.CreateClient();
    }
    
    [Theory]
    [MemberData(nameof(EnumerableRange))]
    public async Task WeatherForecast_ShouldNotBeEmpty_2(int number)
    {
        var response = await _cleint.GetAsync("/weatherforecast");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.NotEmpty(content);
    }

    [Theory]
    [MemberData(nameof(EnumerableRange))]
    public async Task WeatherForecast_ShouldNotBeWhiteSpace_2(int number)
    {
        var response = await _cleint.GetAsync("/weatherforecast");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
    }
    
    [Theory]
    [MemberData(nameof(EnumerableRange))]
    public async Task WeatherForecast_ShouldBeArray_2(int number)
    {
        var response = await _cleint.GetAsync("/weatherforecast");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.True(content.StartsWith('['));
        Assert.True(content.EndsWith(']'));
    }
    
    public static object[][] EnumerableRange = Enumerable.Range(1, 50).Select(i => new object[] { i }).ToArray();
}