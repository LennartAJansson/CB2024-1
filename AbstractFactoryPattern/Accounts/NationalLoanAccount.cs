namespace AbstractFactoryPattern.Accounts;

using AbstractFactoryPattern.Interfaces;

public class NationalLoanAccount : ILoanAccount
{
  public NationalLoanAccount() 
    => Console.WriteLine("Returned National Loan Account");
}
