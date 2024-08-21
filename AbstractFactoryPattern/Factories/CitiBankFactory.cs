namespace AbstractFactoryPattern.Factories;

using AbstractFactoryPattern.Accounts;
using AbstractFactoryPattern.Interfaces;

public class CitiBankFactory : IAbstractBankFactory
{
  public ILoanAccount CreateLoanAccount() 
    => new CitiLoanAccount();

  public ISavingsAccount CreateSavingsAccount() 
    => new CitiSavingsAccount();
}
