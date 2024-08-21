namespace DIHostBuilder;

using DISimple;

public class Worker : BackgroundService
{
  private readonly ILogger<Worker> logger;
  private readonly IApplicationLayer application;

  public Worker(ILogger<Worker> logger, IApplicationLayer application)
  {
    this.logger = logger;
    this.application = application;
  }

  protected override async Task ExecuteAsync(CancellationToken stoppingToken)
  {
    while (!stoppingToken.IsCancellationRequested)
    {
      if (logger.IsEnabled(LogLevel.Information))
      {
        logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
      }
      await application.Execute();

      await Task.Delay(3000, stoppingToken);
    }
  }
}
