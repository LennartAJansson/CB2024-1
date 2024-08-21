using BuilderPattern.Builders;
using BuilderPattern.Factories;
using BuilderPattern.Items;

List<CarBuilder> carBuilders = [
  new SuperCarBuilder(), 
  new NotSoSuperCarBuilder()];

CarFactory carFactory = new();

foreach (CarBuilder carBuilder in carBuilders)
{
  Car car = carFactory.Build(carBuilder);
  Console.WriteLine($"The car requested by {carBuilder.GetType().Name}:");
  Console.WriteLine($"------------------------------------------");
  Console.WriteLine($"Type       : {carBuilder.GetType()}");
  Console.WriteLine($"HorsePowers: {car.HorsePower}");
  Console.WriteLine($"TopSpeed   : {car.TopSpeedMPH} MPH");
  Console.WriteLine($"Feature    : {car.MostImpressiveFeature}");
}

