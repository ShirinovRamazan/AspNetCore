

using WebApplication2.Views.Contexts.Entities;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        var size = new Size();
        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}