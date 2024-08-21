using OptionsPattern;
using OptionsPattern.Configuration;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.Configure<MyConfiguration>(builder.Configuration.GetSection("MyConfiguration"));

builder.Services.AddHostedService<Worker>();

var host = builder.Build();

host.Run();
