namespace DIWebAppBuilder.Domain;

using DIWebAppBuilder.Abstract;

public sealed class DomainLayer : IDomainLayer
{
  private readonly ILogger<DomainLayer> logger;
  private readonly IServiceLayer serviceLayer;

  public DomainLayer(ILogger<DomainLayer> logger, IServiceLayer serviceLayer)
  {
    this.logger = logger;
    this.serviceLayer = serviceLayer;
    logger.LogInformation("Creating domainlayer");
  }

  public async Task Execute()
  {
    logger.LogInformation("Executing domainlayer");
    await serviceLayer.Execute();
  }
}
