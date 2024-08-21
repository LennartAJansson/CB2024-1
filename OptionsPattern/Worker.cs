namespace OptionsPattern;

using Microsoft.Extensions.Options;

using OptionsPattern.Configuration;

public class Worker : BackgroundService
{
  private readonly ILogger<Worker> logger;
  private readonly MyConfiguration myConfiguration;

  public Worker(ILogger<Worker> logger, IOptions<MyConfiguration> options)
  {
    this.logger = logger;
    myConfiguration = options.Value;
  }

  protected override async Task ExecuteAsync(CancellationToken stoppingToken)
  {
    while (!stoppingToken.IsCancellationRequested)
    {
      if (logger.IsEnabled(LogLevel.Information))
      {
        logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        logger.LogInformation("Config values: {intValue}, {stringValue}", myConfiguration.MyIntValue, myConfiguration.MyStringValue);
      }
      await Task.Delay(1000, stoppingToken);
    }
  }
}
