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
    
    [Fact]
    public async Task Users_ShouldBeSuccess_21()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_22()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_23()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_24()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_25()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_26()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_27()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_28()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_29()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_30()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_31()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_32()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_33()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_34()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_35()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_36()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_37()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_38()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_39()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_40()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_41()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_42()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_43()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_44()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_45()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_46()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_47()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_48()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_49()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_50()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_51()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_52()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_53()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_54()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_55()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_56()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_57()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_58()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_59()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_60()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_61()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_62()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_63()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_64()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_65()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_66()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_67()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_68()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_69()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_70()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_71()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_72()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_73()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_74()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_75()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_76()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_77()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_78()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_79()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_80()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_81()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_82()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_83()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_84()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_85()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_86()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_87()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_88()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_89()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_90()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_91()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_92()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_93()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_94()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_95()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_96()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_97()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_98()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_99()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeSuccess_100()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
}