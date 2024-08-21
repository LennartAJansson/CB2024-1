using ConfigurationHostBuilder;

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration.AddUserSecrets<Program>();

builder.Services.AddHostedService<Worker>();

var host = builder.Build();

host.Run();
