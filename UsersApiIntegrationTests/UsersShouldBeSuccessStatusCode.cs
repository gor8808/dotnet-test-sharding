namespace UsersApiIntegrationTests;

public class UsersShouldBeSuccessStatusCode
{
    private readonly HttpClient _cleint;

    public UsersShouldBeSuccessStatusCode(UsersApiFixture fixture)
    {
        _cleint = fixture.Factory.CreateClient();
    }
    
    [Theory]
    [MemberData(nameof(EnumerableRange))]
    public async Task Users_ShouldBeSuccessStatusCode(int number)
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
    }
    
    public static object[][] EnumerableRange = Enumerable.Range(1, 50).Select(i => new object[] { i }).ToArray();
}