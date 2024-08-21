namespace DIWebAppBuilder.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DIWebAppBuilder.Abstract;
using DIWebAppBuilder.Application;
using DIWebAppBuilder.Domain;
using DIWebAppBuilder.Services;

using Microsoft.Extensions.DependencyInjection;

public static class DISimpleExtensions
{
  public static IServiceCollection AddDiSetup(this IServiceCollection services)
  {
    services.AddSingleton<IDomainLayer, DomainLayer>();
    services.AddSingleton<IServiceLayer, ServiceLayer>();
    services.AddSingleton<IApplicationLayer, ApplicationLayer>();

    return services;
  }
}
