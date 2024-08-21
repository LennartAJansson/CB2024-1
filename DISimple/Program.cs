using DISimple.Abstract;
using DISimple.Application;
using DISimple.Domain;
using DISimple.Extensions;
using DISimple.Services;

using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();

_ = services.AddDiSetup();
//services.AddSingleton<IDomainLayer, DomainLayer>();
//services.AddSingleton<IServiceLayer, ServiceLayer>();
//services.AddSingleton<IApplicationLayer, ApplicationLayer>();

ServiceProvider provider = services.BuildServiceProvider();

using (IServiceScope scope = provider.CreateScope())
{
  IApplicationLayer applicationLayer = scope.ServiceProvider.GetRequiredService<IApplicationLayer>();
  await applicationLayer.Execute();
}
