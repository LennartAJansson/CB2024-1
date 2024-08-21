using ConfigurationProviders;
using Sogeti.Extensions.Configuration.Yaml;

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration.AddYamlFile("Test.yaml");

builder.Services.AddHostedService<Worker>();

var host = builder.Build();

host.Run();
