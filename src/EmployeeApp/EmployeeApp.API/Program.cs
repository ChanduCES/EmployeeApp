using EmployeeApp.API.Constants;

public partial class Program 
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddHealthChecks();
        var app = builder.Build();
        app.MapHealthChecks($"{ApiRoutes.BaseUrl}/{ApiRoutes.HealthCheck}");
        app.Run();
    }
}

public partial class Program { };