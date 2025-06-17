using ASP.Components;
using ASP.Models;

class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        builder.Services.AddSingleton<Todo>(provider => new Todo());
        
        var app = builder.Build();
        app.MapGet("/", () => "Hello World!");
        app.UseSwagger();
        app.UseSwaggerUI();
        app.MapControllers();
        app.Run();
    }
}