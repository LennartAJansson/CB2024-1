namespace DIWebAppBuilder.Services;

using DIWebAppBuilder.Abstract;

public sealed class ServiceLayer : IServiceLayer
{
  private readonly ILogger<ServiceLayer> logger;

  public ServiceLayer(ILogger<ServiceLayer> logger)
  {
    this.logger = logger;
    logger.LogInformation("Creating servicelayer");
  }

  public Task Execute()
  {
    logger.LogInformation("Executing servicelayer");
    return Task.CompletedTask;
  }
}