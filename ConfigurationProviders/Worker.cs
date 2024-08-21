namespace ConfigurationProviders;

public class Worker : BackgroundService
{
  private readonly ILogger<Worker> logger;
  private readonly IConfiguration configuration;

  public Worker(ILogger<Worker> logger, IConfiguration configuration)
  {
    this.logger = logger;
    this.configuration = configuration;
  }

  protected override async Task ExecuteAsync(CancellationToken stoppingToken)
  {
    while (!stoppingToken.IsCancellationRequested)
    {
      if (logger.IsEnabled(LogLevel.Information))
      {
        logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        logger.LogInformation("Json: {Test}", configuration.GetValue<string>("JsonTopSection:JsonSubSection1:JsonKey"));
        logger.LogInformation("Yaml: {Test}", configuration.GetValue<string>("YamlTopSection:YamlSubSection1:YamlKey"));
      }
      await Task.Delay(1000, stoppingToken);
    }
  }
}
