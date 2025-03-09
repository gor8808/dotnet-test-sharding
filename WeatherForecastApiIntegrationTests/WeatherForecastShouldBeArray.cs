namespace WeatherForecastApiIntegrationTests;

public class WeatherForecastShouldBeArray 
{
    private readonly HttpClient _cleint;

    public WeatherForecastShouldBeArray(WeatherForecastApiFixture cases)
    {
        _cleint = cases.Factory.CreateClient();
    }

    [Theory]
    [MemberData(nameof(EnumerableRange))]
    public async Task WeatherForecast_ShouldBeSuccessStatusCode(int number)
    {
        var response = await _cleint.GetAsync("/weatherforecast");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
    }
    
    public static object[][] EnumerableRange = Enumerable.Range(1, 50).Select(i => new object[] { i }).ToArray();
}