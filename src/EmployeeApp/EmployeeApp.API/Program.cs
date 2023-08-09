using EmployeeApp.API.Constants;

public partial class Program 
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddHealthChecks();
        builder.Services.AddMvcCore();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();
        app.MapHealthChecks($"{ApiRoutes.BaseUrl}/{ApiRoutes.HealthCheck}");
        
        app.UseSwagger();
        app.UseSwaggerUI();

        app.Run();
    }
}

public partial class Program { };