namespace DISimple;

using System.Threading.Tasks;

public sealed class ApplicationLayer : IApplicationLayer
{
  private readonly ILogger<ApplicationLayer> logger;
  private readonly IDomainLayer domainLayer;

  public ApplicationLayer(ILogger<ApplicationLayer> logger, IDomainLayer domainLayer)
  {
    this.logger = logger;
    this.domainLayer = domainLayer;
    logger.LogInformation("Creating applicationlayer");
  }

  public async Task Execute()
  {
    logger.LogInformation("Executing applicationlayer");
    await domainLayer.Execute();
  }
}
