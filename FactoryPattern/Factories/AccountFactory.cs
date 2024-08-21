namespace FactoryPattern.Factories;

using FactoryPattern.Interfaces;

using FactoryPattern.Accounts;

public class AccountFactory 
{
  public static ISavingsAccount GetSavingsAccount(string acctNo) 
    => acctNo.Contains("CITI")
          ? new CitiSavingsAcct()
          : acctNo.Contains("NATIONAL")
              ? new NationalSavingsAcct()
              : throw new ArgumentException("Invalid Account Number");
}
