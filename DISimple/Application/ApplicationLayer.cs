namespace DISimple.Application;

using System.Threading.Tasks;

using DISimple.Abstract;

public sealed class ApplicationLayer : IApplicationLayer
{
  private readonly IDomainLayer domainLayer;

  public ApplicationLayer(IDomainLayer domainLayer)
  {
    this.domainLayer = domainLayer;
    Console.WriteLine("Creating applicationlayer");
  }

  public async Task Execute()
  {
    Console.WriteLine("Executing applicationlayer");
    await domainLayer.Execute();
  }
}
