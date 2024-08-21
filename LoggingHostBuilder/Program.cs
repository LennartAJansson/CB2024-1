using LoggingHostBuilder;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

IHost host = builder.Build();

LogStartup();

host.Run();

void LogStartup()
{
  using (IServiceScope scope = host.Services.CreateScope())
  {
    IServiceProvider services = scope.ServiceProvider;
    ILoggerFactory loggerFactory = services.GetRequiredService<ILoggerFactory>();
    ILogger<Program> logger = loggerFactory.CreateLogger<Program>();

    logger.LogInformation("Starting application");
  }
}
