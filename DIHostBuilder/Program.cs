using DIHostBuilder;

using DISimple.Extensions;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddDiSetup();

builder.Services.AddHostedService<Worker>();

var host = builder.Build();

host.Run();
