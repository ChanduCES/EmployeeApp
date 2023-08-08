using EmployeeApp.API.Constants;

public partial class Program 
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddHealthChecks();
        var app = builder.Build();
        app.MapHealthChecks($"{Endpoints.BaseUrl}/{Endpoints.HealthCheck}");
        app.Run();
    }
}

public partial class Program { };