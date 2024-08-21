namespace AbstractFactoryPattern.Accounts;

using AbstractFactoryPattern.Interfaces;

public class CitiSavingsAccount : ISavingsAccount
{
  public CitiSavingsAccount() 
    => Console.WriteLine("Returned Citi Savings Account");
}
