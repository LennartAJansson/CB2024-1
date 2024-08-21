namespace DISimple.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISimple.Abstract;
using DISimple.Application;
using DISimple.Domain;
using DISimple.Services;

using Microsoft.Extensions.DependencyInjection;

public static class DISimpleExtensions
{
  public static IServiceCollection AddDiSetup(this IServiceCollection services)
  {
    services.AddSingleton<IDomainLayer, DomainLayer>();
    //services.AddSingleton<IServiceLayer, ServiceLayer>();
    services.AddSingleton<IApplicationLayer, ApplicationLayer>();

    return services;
  }
}
