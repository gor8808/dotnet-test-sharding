using Microsoft.AspNetCore.Mvc.Testing;

namespace UsersApiIntegrationTests;

public class UsersShouldBeSuccessStatusCode
{
    private readonly HttpClient _cleint;

    public UsersShouldBeSuccessStatusCode(UsersApiFixture fixture)
    {
        _cleint = fixture.Factory.CreateClient();
    }
    
    [Fact]
    public async Task Users_ShouldBeSuccess_11()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    
    [Fact]
    public async Task Users_ShouldBeSuccess_12()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_13()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_14()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_15()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_16()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_17()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_18()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_19()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_20()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_1()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    
    [Fact]
    public async Task Users_ShouldBeSuccess_2()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_3()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_4()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_5()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_6()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_7()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_8()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_9()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeSuccess_10()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
}