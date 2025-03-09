using Microsoft.AspNetCore.Mvc.Testing;

namespace UsersApiIntegrationTests;

public class UsersShouldBeArray
{
    private readonly HttpClient _cleint;

    public UsersShouldBeArray(UsersApiFixture fixture)
    {
        _cleint = fixture.Factory.CreateClient();
    }

    
    [Theory]
    [MemberData(nameof(EnumerableRange))]
    public async Task Users_ShouldBeArray(int number)
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    
    public static object[][] EnumerableRange = Enumerable.Range(1, 50).Select(i => new object[] { i }).ToArray();
}