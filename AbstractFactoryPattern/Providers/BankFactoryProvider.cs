namespace AbstractFactoryPattern.Providers;

using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Interfaces;

public class BankFactoryProvider
{
  public static IAbstractBankFactory? GetBankFactory(string accountNo)
  {
    if (accountNo.Contains("CITI"))
    {
      return new CitiBankFactory();
    }
    else if (accountNo.Contains("NATIONAL"))
    {
      return new NationalBankFactory();
    }
    else
    {
      return null;
    }
  }
}
