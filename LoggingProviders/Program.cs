using LoggingProviders;
using Sogeti.Extensions.Logging.ColorConsole;

var builder = Host.CreateApplicationBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddColorConsoleLogger(config =>
{
    config.LogLevels[LogLevel.Information] = ConsoleColor.Green;
    config.LogLevels[LogLevel.Warning] = ConsoleColor.Yellow;
    config.LogLevels[LogLevel.Error] = ConsoleColor.Red;
});

builder.Services.AddHostedService<Worker>();

var host = builder.Build();

host.Run();
