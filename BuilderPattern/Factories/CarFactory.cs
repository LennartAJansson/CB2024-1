using BuilderPattern.Builders;
using BuilderPattern.Items;

namespace BuilderPattern.Factories;

public class CarFactory
{
  public Car Build(CarBuilder builder)
  {
    builder.SetTopSpeed();
    builder.SetHorsePower();
    builder.SetImpressiveFeature();
    return builder.Build();
  }
}
