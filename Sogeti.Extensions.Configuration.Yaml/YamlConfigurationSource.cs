namespace Sogeti.Extensions.Configuration.Yaml;

using Microsoft.Extensions.Configuration;

public sealed class YamlConfigurationSource : FileConfigurationSource
{
  public override IConfigurationProvider Build(IConfigurationBuilder builder)
  {
    EnsureDefaults(builder);

    return new YamlConfigurationProvider(this);
  }
}