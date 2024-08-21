namespace AbstractFactoryPattern.Accounts;

using AbstractFactoryPattern.Interfaces;

public class CitiLoanAccount : ILoanAccount
{
  public CitiLoanAccount() 
    => Console.WriteLine("Returned Citi Loan Account");
}
