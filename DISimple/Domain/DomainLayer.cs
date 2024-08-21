namespace DISimple.Domain;
using DISimple.Abstract;

public sealed class DomainLayer : IDomainLayer
{
  private readonly IServiceLayer serviceLayer;

  public DomainLayer(IServiceLayer serviceLayer)
  {
    this.serviceLayer = serviceLayer;
    Console.WriteLine("Creating domainlayer");
  }

  public async Task Execute()
  {
    Console.WriteLine("Executing domainlayer");
    await serviceLayer.Execute();
  }
}
