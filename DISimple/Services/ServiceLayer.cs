using DISimple.Abstract;

namespace DISimple.Services;

public sealed class ServiceLayer : IServiceLayer
{
    public ServiceLayer()
    {
        Console.WriteLine("Creating servicelayer");
    }

    public Task Execute()
    {
        Console.WriteLine("Executing servicelayer");
        return Task.CompletedTask;
    }
}