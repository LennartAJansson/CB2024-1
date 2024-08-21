namespace FactoryPattern.Accounts;

using FactoryPattern.Interfaces;

public abstract class SavingsAccount : ISavingsAccount
{
  public decimal Balance { get; set; }
}
