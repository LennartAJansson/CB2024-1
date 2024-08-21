namespace AbstractFactoryPattern.Accounts;

using AbstractFactoryPattern.Interfaces;

public class NationalSavingsAccount : ISavingsAccount
{
  public NationalSavingsAccount() 
    => Console.WriteLine("Returned National Savings Account");
}
