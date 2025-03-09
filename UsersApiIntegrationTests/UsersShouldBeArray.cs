using Microsoft.AspNetCore.Mvc.Testing;

namespace UsersApiIntegrationTests;

public class UsersShouldBeArray
{
    private readonly HttpClient _cleint;

    public UsersShouldBeArray(UsersApiFixture fixture)
    {
        _cleint = fixture.Factory.CreateClient();
    }

    
    [Fact]
    public async Task Users_ShouldBearray_11()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    
    [Fact]
    public async Task Users_ShouldBearray_12()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBearray_13()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBearray_14()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBearray_15()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBearray_16()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBearray_17()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBearray_18()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBearray_19()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBearray_20()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeArray_1()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    
    [Fact]
    public async Task Users_ShouldBeArray_2()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeArray_3()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeArray_4()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeArray_5()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeArray_6()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeArray_7()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeArray_8()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeArray_9()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    [Fact]
    public async Task Users_ShouldBeArray_10()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    
    [Fact]
    public async Task Users_ShouldBeArray_21()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_22()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_23()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_24()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_25()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_26()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_27()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_28()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_29()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_30()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_31()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_32()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_33()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_34()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_35()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_36()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_37()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_38()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_39()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_40()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_41()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_42()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_43()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_44()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_45()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_46()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_47()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_48()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_49()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_50()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_51()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_52()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_53()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_54()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_55()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_56()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_57()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_58()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_59()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_60()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_61()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_62()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_63()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_64()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_65()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_66()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_67()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_68()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_69()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_70()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_71()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_72()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_73()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_74()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_75()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_76()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_77()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_78()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_79()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_80()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_81()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_82()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_83()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_84()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_85()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_86()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_87()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_88()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_89()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_90()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_91()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_92()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_93()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_94()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_95()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_96()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_97()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_98()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_99()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
    


    [Fact]
    public async Task Users_ShouldBeArray_100()
    {
        var response = await _cleint.GetAsync("/users");
        
        response.EnsureSuccessStatusCode();
        
        var content = await response.Content.ReadAsStringAsync();
        Assert.False(string.IsNullOrWhiteSpace(content));
        Assert.True(content.StartsWith("[") && content.EndsWith("]"));
    }
}