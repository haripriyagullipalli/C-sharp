using Order.Models;

public  class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddHttpClient(); // Register HttpClient factory globally
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddSingleton<Orders>();
        
        builder.Services.AddHttpClient<UserServiceClient>((client) => client.BaseAddress = new Uri("http://localhost:5215"));
        builder.Services.AddHttpClient<ProductServiceClient>((client) => client.BaseAddress = new Uri("http://localhost:5066"));
        builder.Services.AddSingleton<Orders>();
        var app = builder.Build();
        app.MapGet("/", () => "Hello World!");
        app.UseSwagger();
        app.UseSwaggerUI();
        app.MapControllers();
        app.Run();
    }
}