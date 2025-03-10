﻿namespace Sogeti.Extensions.Configuration.Yaml;

using System;
using System.IO;

using Microsoft.Extensions.Configuration;

using YamlDotNet.Core;

public sealed class YamlConfigurationProvider : FileConfigurationProvider
{
  public YamlConfigurationProvider(YamlConfigurationSource source)
      : base(source)
  { }

  public override void Load(Stream stream)
  {
    YamlConfigurationFileParser parser = new();

    try
    {
      Data = parser.Parse(stream);
    }
    catch (YamlException e)
    {
      throw new FormatException(Resources.FormatError_YamlParseError(e.Message), e);
    }
  }
}