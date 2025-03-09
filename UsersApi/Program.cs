namespace UsersApi;
    
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.MapGet("/users", () =>
            {

                var forecast = Enumerable.Range(1, 5).Select(index =>
                        new User
                        (
                            index, $"User {index}", $"User {index}", Random.Shared.Next(1, 60)
                        ))
                    .ToArray();
                return forecast;
            })
            .WithOpenApi();

        app.Run();
    }
}

internal record User(int Id, string Name, string UserName, int Age)
{
    public string FullName => Name + " " + UserName;
}