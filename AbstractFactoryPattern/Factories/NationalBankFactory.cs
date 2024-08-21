namespace AbstractFactoryPattern.Factories;

using AbstractFactoryPattern.Accounts;
using AbstractFactoryPattern.Interfaces;

public class NationalBankFactory : IAbstractBankFactory
{
  public ILoanAccount CreateLoanAccount() 
    => new NationalLoanAccount();

  public ISavingsAccount CreateSavingsAccount() 
    => new NationalSavingsAccount();
}
